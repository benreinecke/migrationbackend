using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class MigrationStatus
{
    public int Step { get; set; }

    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Schema { get; set; }

    public string? Dbname { get; set; }

    public string? Tablename { get; set; }

    public string? Fullname { get; set; }

    public string? Action { get; set; }

    public string? Rollback { get; set; }

    public long? Nrows { get; set; }

    public long? Kbs { get; set; }

    public DateTime Timestamp { get; set; }

    public bool? Partition { get; set; }

    public bool? IsMemoryOptimized { get; set; }
}
