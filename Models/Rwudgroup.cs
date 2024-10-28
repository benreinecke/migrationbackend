using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class Rwudgroup
{
    public int GroupId { get; set; }

    public string? GroupType { get; set; }

    public string? GroupName { get; set; }

    public int? GroupOrder { get; set; }

    public string? SchoolCode { get; set; }

    public bool? DistrictWide { get; set; }
}
