using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class ASummaryOfTablesExported
{
    public string TableName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long? TotalRowCount { get; set; }

    public string AddUpdatesToBoiler { get; set; } = null!;

    public string? Required { get; set; }
}
