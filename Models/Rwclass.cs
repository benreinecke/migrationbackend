using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class Rwclass
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public string? Section { get; set; }

    public int? YearId { get; set; }

    public short? Capacity { get; set; }

    public int? StaffId { get; set; }

    public short? RoomId { get; set; }

    public int? Pattern { get; set; }

    public int ClassId { get; set; }

    public int? RequiredRoom { get; set; }

    public bool Term1 { get; set; }

    public bool Term2 { get; set; }

    public bool Term3 { get; set; }

    public bool Term4 { get; set; }

    public bool Term5 { get; set; }

    public bool Term6 { get; set; }

    public short? Terms { get; set; }

    public bool LetterGrade { get; set; }

    public string? GbkGradeMethod { get; set; }

    public bool Homeroom { get; set; }

    public int? AltStaffId { get; set; }

    public int? AidId { get; set; }

    public bool GbkIncompleteis0 { get; set; }

    public int GbkStudentSort { get; set; }

    public int GbkAssignmentSort { get; set; }

    public bool GbkAutoEmailFail { get; set; }

    public bool? GbkWebProgressReport { get; set; }

    public string? Team { get; set; }

    public bool? GbkShowPointsEarned { get; set; }

    public bool? GbkCapCategory { get; set; }

    public bool? GbkCapTerm { get; set; }

    public string? GradeLevels { get; set; }

    public string? MaleFemale { get; set; }

    public bool? Closed { get; set; }

    public int? MaxSize { get; set; }

    public string? WebProgressReportStyle { get; set; }

    public float? Weight { get; set; }

    public string? Pwteacher { get; set; }

    public string? Pwhomework { get; set; }

    public string? PwlessonPlan { get; set; }

    public int? GbkDecimalPlaces { get; set; }

    public string? GbkTimeFrame { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Comment1 { get; set; }

    public string? Comment2 { get; set; }

    public string? Comment3 { get; set; }

    public string? Comment4 { get; set; }

    public string? Comment5 { get; set; }

    public string? Comment6 { get; set; }

    public bool? NoDayAttendance { get; set; }

    public int? TemplateId { get; set; }

    public int? LinkedClassId { get; set; }

    public bool? LockSchedule { get; set; }

    public bool? LockEnrollment { get; set; }

    public bool? EnableMoodle { get; set; }

    public int SeatingChartColumn { get; set; }

    public int SeatingChartRow { get; set; }

    public string? Color { get; set; }

    public bool GbkShowCurve { get; set; }

    public string? ColorText { get; set; }

    public bool AllowStandardGrading { get; set; }

    public string? LegacyClassId { get; set; }

    public bool ClassLms { get; set; }

    public bool AllowStudentComment { get; set; }

    public bool AllowStudentPost { get; set; }

    public bool EnableStandardTagging { get; set; }

    public decimal? StandardMaxGrade { get; set; }

    public int GbkDefaultView { get; set; }

    public bool IsStandardsBasedCalculation { get; set; }

    public decimal? StandardMasteryGradeMinVal0 { get; set; }

    public decimal? StandardMasteryGradeMinVal1 { get; set; }

    public decimal? StandardMasteryGradeMinVal2 { get; set; }

    public decimal? DefaultAssignmentMaxPoints { get; set; }

    public int GbkStandardCalculation { get; set; }

    public int GbkStandardCalculationRecent { get; set; }

    public string? GoogleCourseId { get; set; }

    public short StandardAssignmentGradeFlowType { get; set; }

    public string RoomOrientationMarker { get; set; } = null!;

    public decimal GbkStandardCalculationDecayRate { get; set; }
}
