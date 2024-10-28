using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class CheckChurchName
{
    public string ValueCategory { get; set; } = null!;

    public string? Value { get; set; }

    public string NewValue { get; set; } = null!;
}
