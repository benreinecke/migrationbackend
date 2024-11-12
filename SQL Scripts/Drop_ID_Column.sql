-- Script to remove id column as primary key for all tables in the val schema
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
    -- Check if the table has a primary key constraint on the "id" column
    SELECT @PrimaryKeyName = kc.name
    FROM sys.key_constraints kc
    JOIN sys.index_columns ic ON kc.parent_object_id = ic.object_id AND kc.unique_index_id = ic.index_id
    JOIN sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
    JOIN sys.tables t ON kc.parent_object_id = t.object_id
    JOIN sys.schemas s ON t.schema_id = s.schema_id
    WHERE s.name = @SchemaName AND t.name = @TableName AND kc.type = 'PK' AND c.name = 'id';

    -- Drop the primary key constraint if it exists
    IF @PrimaryKeyName IS NOT NULL
    BEGIN
        SET @Sql = 'ALTER TABLE ' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + 
                   ' DROP CONSTRAINT ' + QUOTENAME(@PrimaryKeyName);
        EXEC sp_executesql @Sql;
    END

    -- Check if the "id" column exists in the table
    IF EXISTS (
        SELECT 1
        FROM sys.columns c
        JOIN sys.tables t ON c.object_id = t.object_id
        JOIN sys.schemas s ON t.schema_id = s.schema_id
        WHERE s.name = @SchemaName AND t.name = @TableName AND c.name = 'id'
    )
    BEGIN
        -- Drop the "id" column
        SET @Sql = 'ALTER TABLE ' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + 
                   ' DROP COLUMN id';
        EXEC sp_executesql @Sql;
    END;

    FETCH NEXT FROM TableCursor INTO @TableName;
END;

CLOSE TableCursor;
DEALLOCATE TableCursor;
