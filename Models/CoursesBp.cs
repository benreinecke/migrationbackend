using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class CoursesBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? LegacyCourseId { get; set; }

    public string? Title { get; set; }

    public string? Credits { get; set; }

    public string? Description { get; set; }

    public string? ReportCard { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? CourseLevel { get; set; }

    public string? Calc { get; set; }

    public string? Attendance { get; set; }

    public string? Activity { get; set; }

    public string? Homeroom { get; set; }

    public string? Department { get; set; }

    public string? Active { get; set; }

    public string? Elective { get; set; }

    public string? Hs { get; set; }

    public string? MiddleSchool { get; set; }

    public string? Elementary { get; set; }

    public string? PreSchool { get; set; }

    public string? TranscriptLoad { get; set; }

    public string? NoCalcTranscript { get; set; }

    public string? Weight { get; set; }

    public string? Rcplacement { get; set; }

    public string? StateId { get; set; }

    public string? MaxSize { get; set; }
}
