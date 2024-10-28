using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class CourseGradelevelsBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? CourseId { get; set; }

    public string? GradeLevel { get; set; }
}
