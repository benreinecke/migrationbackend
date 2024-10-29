using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwschoolYear
{
    public int YearId { get; set; }

    public DateTime? FirstDay { get; set; }

    public DateTime? LastDay { get; set; }

    public string? SchoolYear { get; set; }

    public int? SchoolId { get; set; }

    public string? SchoolCode { get; set; }

    public bool? SummerSchool { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool OarequestInfoEnabled { get; set; }

    public bool IsTemplate { get; set; }

    public string? FactstermCode { get; set; }

    public bool BlockAcademicYear { get; set; }
}
