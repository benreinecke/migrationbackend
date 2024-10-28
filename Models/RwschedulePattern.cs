using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class RwschedulePattern
{
    public int PatternNumber { get; set; }

    public int TemplateId { get; set; }

    public string? Name { get; set; }

    public string? PatternGroup { get; set; }

    public int? SortOrder { get; set; }
}
