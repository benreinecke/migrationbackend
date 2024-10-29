using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Rwstaff
{
    public string? Legacypersonid { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public int StaffId { get; set; }

    public bool? Active { get; set; }

    public string? Salutation { get; set; }

    public string? Suffix { get; set; }

    public string? NickName { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Gender { get; set; }

    public string? Ethnicity { get; set; }

    public string? Citizenship { get; set; }

    public string? Ssn { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public string? Note { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public string? CellPhone { get; set; }

    public bool? Administrator { get; set; }

    public bool? Faculty { get; set; }

    public bool? DistrictUser { get; set; }

    public bool? Substitute { get; set; }

    public string? Department { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? RoomId { get; set; }

    public bool? FullTime { get; set; }

    public float? Fte { get; set; }

    public bool? Preschool { get; set; }

    public bool? MiddleSchool { get; set; }

    public bool? Hs { get; set; }

    public bool? Elementary { get; set; }

    public int? AddressId { get; set; }

    public string? Occupation { get; set; }

    public string? WorkPhone { get; set; }

    public string? Denomination { get; set; }

    public int? ChurchId { get; set; }

    public int? FinancialFamilyId { get; set; }

    public string? Password { get; set; }

    public int? EducationLevel { get; set; }

    public string? Highschool { get; set; }

    public string? BachelorSchool { get; set; }

    public string? BachelorDegree { get; set; }

    public string? BachelorYear { get; set; }

    public string? MasterSchool { get; set; }

    public string? MasterDegree { get; set; }

    public string? MasterYear { get; set; }

    public string? Phdschool { get; set; }

    public string? Phddegree { get; set; }

    public string? Phdyear { get; set; }

    public string? BachelorSchool2 { get; set; }

    public string? BachelorDegree2 { get; set; }

    public string? BachelorYear2 { get; set; }

    public string? MasterSchool2 { get; set; }

    public string? MasterDegree2 { get; set; }

    public string? MasterYear2 { get; set; }

    public string? Phdschool2 { get; set; }

    public string? Phddegree2 { get; set; }

    public string? Phdyear2 { get; set; }

    public int PersonId { get; set; }

    public int? Pda { get; set; }

    public bool? StaffDirectoryBlock { get; set; }

    public string? WorkPhoneExtension { get; set; }

    public string? PathToPicture { get; set; }

    public bool? UnsubscribeRenWebEmail { get; set; }
}
