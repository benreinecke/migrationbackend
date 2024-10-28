using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class UdconfigBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? DistrictWide { get; set; }

    public string? GroupType { get; set; }

    public string? GroupOrder { get; set; }

    public string? GroupName { get; set; }

    public string? FieldOrder { get; set; }

    public string? FieldName { get; set; }

    public string? FieldDataType { get; set; }
}
