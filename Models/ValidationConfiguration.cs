using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ValidationConfiguration
{
    public string Name { get; set; } = null!;

    public string? TargetColumns { get; set; }

    public bool Required { get; set; }

    public string OutputFile { get; set; } = null!;

    public string? UpdateLinksBy { get; set; }

    public string? ColumnLinkColumn { get; set; }

    public string? OriginalValueColumn { get; set; }

    public string? Boilers { get; set; }

    public string Description { get; set; } = null!;
}
