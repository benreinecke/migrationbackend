using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class Rwcourse
{
    public int CourseId { get; set; }

    public string? Title { get; set; }

    public double? Credits { get; set; }

    public bool ReportCard { get; set; }

    public bool Transcript { get; set; }

    public string? Abbreviation { get; set; }

    public int? Terms { get; set; }

    public int? RequiredRoomId { get; set; }

    public int? LevelId { get; set; }

    public bool Calc { get; set; }

    public bool Attendance { get; set; }

    public bool Activity { get; set; }

    public bool HomeRoom { get; set; }

    public string? SchoolCode { get; set; }

    public string? Department { get; set; }

    public bool? Active { get; set; }

    public int? Contacts { get; set; }

    public string? Prerequisites { get; set; }

    public string? Corequisites { get; set; }

    public string? Equivalents { get; set; }

    public string? ReqGrade { get; set; }

    public string? CourseType { get; set; }

    public bool? Elective { get; set; }

    public int? LinkedCourseId { get; set; }

    public bool? Hs { get; set; }

    public float? CourseFee { get; set; }

    public float? MaterialFee { get; set; }

    public float? LabFee { get; set; }

    public float? MiscFee { get; set; }

    public int? CourseAcctCat { get; set; }

    public int? MaterialAcctCat { get; set; }

    public int? LabAcctCat { get; set; }

    public int? MiscAcctCat { get; set; }

    public int? DepartmentId { get; set; }

    public bool? CalcTranscript { get; set; }

    public bool? PreSchool { get; set; }

    public bool? Elementary { get; set; }

    public bool? MidleSchool { get; set; }

    public double? TermWt { get; set; }

    public double? SemesterWt { get; set; }

    public double? FinalWt { get; set; }

    public int? TranscriptLoad { get; set; }

    public bool? NoCalcTranscript { get; set; }

    public float? Weight { get; set; }

    public int? Rcplacement { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? MaxSize { get; set; }

    public string? StateId { get; set; }

    public int? DefaultStaffId { get; set; }

    public int? ScheduleStyle { get; set; }

    public string? PatternGroup { get; set; }

    public string? Description { get; set; }

    public bool? EnableMoodle { get; set; }

    public int? MoodleCourseId { get; set; }

    public bool MoodleGuestAccess { get; set; }

    public int? IbcourseId { get; set; }

    public string? LegacyCourseId { get; set; }
}
