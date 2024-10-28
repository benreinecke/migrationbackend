using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class RwstudentRank
{
    public int StudentId { get; set; }

    public int YearId { get; set; }

    public int TermId { get; set; }

    public string? GradeLevel { get; set; }

    public float TermAvg { get; set; }

    public float TermGpa { get; set; }

    public float TermHighAvg { get; set; }

    public float TermLowAvg { get; set; }

    public float TermHighGpa { get; set; }

    public float TermLowGpa { get; set; }

    public int TermRank { get; set; }

    public int RankCount { get; set; }

    public int HonorId { get; set; }

    public string? Udhonor1 { get; set; }

    public string? Udhonor2 { get; set; }

    public string? Udhonor3 { get; set; }

    public string? Udhonor4 { get; set; }

    public string? Udhonor5 { get; set; }

    public DateTime? RankDate { get; set; }

    public float? CreditsAttempted { get; set; }

    public float? CreditsEarned { get; set; }

    public int? HonorRollId { get; set; }

    public float? TermUgpa { get; set; }

    public float? TermHighUgpa { get; set; }

    public float? TermLowUgpa { get; set; }

    public int AutoNum { get; set; }
}
