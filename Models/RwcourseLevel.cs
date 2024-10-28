using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class RwcourseLevel
{
    public string? LevelName { get; set; }

    public string? Description { get; set; }

    public string? SchoolCode { get; set; }

    public int CourseLevelId { get; set; }

    public bool? Honors { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? GbkGradeMethod { get; set; }

    public bool? GbkIncompleteIs0 { get; set; }

    public int? GbkStudentSort { get; set; }

    public int? GbkAssignmentSort { get; set; }

    public bool? GbkShowPointsEarned { get; set; }

    public bool? GbkCapCategory { get; set; }

    public bool? GbkCapTerm { get; set; }

    public int? GbkDecimalPlaces { get; set; }

    public string? GbkTimeFrame { get; set; }

    public string? WebProgressReportStyle { get; set; }

    public bool? GbkWebProgressReport { get; set; }

    public float? S1T1 { get; set; }

    public float? S1T2 { get; set; }

    public float? S1T3 { get; set; }

    public float? S1T4 { get; set; }

    public float? S1T5 { get; set; }

    public float? S1T6 { get; set; }

    public float? S1E1 { get; set; }

    public float? S1E2 { get; set; }

    public float? S2T1 { get; set; }

    public float? S2T2 { get; set; }

    public float? S2T3 { get; set; }

    public float? S2T4 { get; set; }

    public float? S2T5 { get; set; }

    public float? S2T6 { get; set; }

    public float? S2E1 { get; set; }

    public float? S2E2 { get; set; }

    public float? FT1 { get; set; }

    public float? FT2 { get; set; }

    public float? FT3 { get; set; }

    public float? FT4 { get; set; }

    public float? FT5 { get; set; }

    public float? FT6 { get; set; }

    public float? FE1 { get; set; }

    public float? FE2 { get; set; }

    public short? DecimalPlaces { get; set; }

    public float? FS1 { get; set; }

    public float? FS2 { get; set; }

    public float? S3T1 { get; set; }

    public float? S3T2 { get; set; }

    public float? S3T3 { get; set; }

    public float? S3T4 { get; set; }

    public float? S3T5 { get; set; }

    public float? S3T6 { get; set; }

    public float? FE3 { get; set; }

    public float? FS3 { get; set; }

    public float? S3E1 { get; set; }

    public float? S3E2 { get; set; }

    public float? S3E3 { get; set; }

    public float? S1E3 { get; set; }

    public float? S2E3 { get; set; }

    public bool AllowStandardGrading { get; set; }

    public bool EnableStandardTagging { get; set; }

    public decimal? DefaultAssignmentMaxPoints { get; set; }

    public decimal? StandardMaxGrade { get; set; }

    public bool IsStandardsBasedCalculation { get; set; }

    public decimal? StandardMasteryGradeMinVal0 { get; set; }

    public decimal? StandardMasteryGradeMinVal1 { get; set; }

    public decimal? StandardMasteryGradeMinVal2 { get; set; }

    public bool GbkShowCurve { get; set; }

    public int GbkStandardCalculation { get; set; }

    public int GbkStandardCalculationRecent { get; set; }

    public short StandardAssignmentGradeFlowType { get; set; }

    public decimal GbkStandardCalculationDecayRate { get; set; }
}
