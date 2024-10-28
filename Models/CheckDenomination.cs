using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class CheckDenomination
{
    public string ValueCategory { get; set; } = null!;

    public string? Denomination { get; set; }

    public string InDefinedList { get; set; } = null!;

    public string NewValue { get; set; } = null!;
}
