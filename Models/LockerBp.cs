using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class LockerBp
{
    public int RecId { get; set; }

    public string? Locker { get; set; }

    public string? Combo1 { get; set; }

    public string? Combo2 { get; set; }

    public string? Combo3 { get; set; }

    public string? Combo4 { get; set; }

    public string? Combo5 { get; set; }

    public string? CurrentCombo { get; set; }

    public string? Note { get; set; }

    public string? SchoolCode { get; set; }
}
