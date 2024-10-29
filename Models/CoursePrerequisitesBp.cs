using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class CoursePrerequisitesBp
{
    public int RecId { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? CourseId { get; set; }

    public string? PrereqAbbreviation { get; set; }

    public string? PrereqCourseId { get; set; }
}
