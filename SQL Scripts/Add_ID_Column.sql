-- Script to add id column as primary key for all tables in the val schema
DECLARE @SchemaName NVARCHAR(128) = 'val';
DECLARE @TableName NVARCHAR(128);
DECLARE @PrimaryKeyName NVARCHAR(128);
DECLARE @Sql NVARCHAR(MAX);

DECLARE TableCursor CURSOR FOR
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @SchemaName AND TABLE_TYPE = 'BASE TABLE';

OPEN TableCursor;
FETCH NEXT FROM TableCursor INTO @TableName;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Retrieve the primary key constraint name, if it exists
    SELECT @PrimaryKeyName = kc.name
    FROM sys.key_constraints kc
    JOIN sys.tables t ON kc.parent_object_id = t.object_id
    JOIN sys.schemas s ON t.schema_id = s.schema_id
    WHERE s.name = @SchemaName AND t.name = @TableName AND kc.type = 'PK';

    -- Drop the primary key constraint if it exists
    IF @PrimaryKeyName IS NOT NULL
    BEGIN
        SET @Sql = 'ALTER TABLE ' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + 
                   ' DROP CONSTRAINT ' + QUOTENAME(@PrimaryKeyName);
        EXEC sp_executesql @Sql;
    END

    -- Add the new "id" column as an identity primary key
    SET @Sql = 'ALTER TABLE ' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + 
               ' ADD id INT IDENTITY(1,1) PRIMARY KEY';
    EXEC sp_executesql @Sql;

    FETCH NEXT FROM TableCursor INTO @TableName;
END;

CLOSE TableCursor;
DEALLOCATE TableCursor;
