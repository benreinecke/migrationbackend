using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class CourseCorequisitesBp
{
    public int RecId { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? CourseId { get; set; }

    public string? CoreqAbbreviation { get; set; }

    public string? CoreqCourseId { get; set; }
}
