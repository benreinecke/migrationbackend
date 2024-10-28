using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class CourseEquivalentsBp
{
    public int RecId { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? CourseId { get; set; }

    public string? EquivalentAbbreviation { get; set; }

    public string? EquivalentCourseId { get; set; }
}
