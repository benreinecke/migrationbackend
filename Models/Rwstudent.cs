using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Rwstudent
{
    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Salutation { get; set; }

    public string? Suffix { get; set; }

    public string? NickName { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Gender { get; set; }

    public string? Ethnicity { get; set; }

    public string? Citizenship { get; set; }

    public string? Ssn { get; set; }

    public string? PrimaryLanguage { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Note { get; set; }

    public int? AddressId { get; set; }

    public string? HomePhone { get; set; }

    public string? CellPhone { get; set; }

    public int? ReducedLunch { get; set; }

    public int StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? Status { get; set; }

    public string? NextStatus { get; set; }

    public string SchoolCode { get; set; } = null!;

    public string? NextSchoolCode { get; set; }

    public DateTime? EnrollDate { get; set; }

    public DateTime? WithdrawDate { get; set; }

    public string? WithdrawReason { get; set; }

    public DateTime? GraduationDate { get; set; }

    public string? GradeLevel { get; set; }

    public string? NextGradeLevel { get; set; }

    public string? Placement { get; set; }

    public int? AdvisorId { get; set; }

    public int? StudentMentorId { get; set; }

    public string? PathToPicture { get; set; }

    public bool? Reenrolled { get; set; }

    public string? ReEnrollMessage { get; set; }

    public bool? ExcludeTermHonorRoll { get; set; }

    public bool? ExcludeCumHonorRoll { get; set; }

    public bool? ExcludeTermRank { get; set; }

    public bool? ExcludeCumRank { get; set; }

    public string? Locker1 { get; set; }

    public string? Combination1 { get; set; }

    public string? Locker2 { get; set; }

    public string? Combination2 { get; set; }

    public string? PublicSchoolDistrict { get; set; }

    public string? PublicSchoolCounty { get; set; }

    public string? PublicSchoolState { get; set; }

    public string? PublicSchoolLocalSchool { get; set; }

    public string? PublicSchoolCode { get; set; }

    public string? Denomination { get; set; }

    public int? ChurchId { get; set; }

    public int PersonId { get; set; }

    public string? TranscriptNote1 { get; set; }

    public string? ClassOf { get; set; }

    public string? Substatus { get; set; }
}
