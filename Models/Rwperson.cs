using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Rwperson
{
    public int PersonId { get; set; }

    public bool? Student { get; set; }

    public bool? Staff { get; set; }

    public bool? Parent { get; set; }

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

    public string? MaritalStatus { get; set; }

    public string? Ssn { get; set; }

    public string? PrimaryLanguage { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public string? Password { get; set; }

    public string? PathToPicture { get; set; }

    public string? Note { get; set; }

    public int? AddressId { get; set; }

    public string? HomePhone { get; set; }

    public string? CellPhone { get; set; }

    public int? StudentId { get; set; }

    public int? StaffId { get; set; }

    public int? ParentId { get; set; }

    public string? AutoMake { get; set; }

    public string? AutoModel { get; set; }

    public string? AutoLicense { get; set; }

    public string? DriversLicense { get; set; }

    public string? PermitNumber { get; set; }

    public string? BloodType { get; set; }

    public string? Doctor { get; set; }

    public string? DoctorPhone { get; set; }

    public string? DoctorAddress { get; set; }

    public string? Hospital { get; set; }

    public string? HospitalAddress { get; set; }

    public bool? Treat { get; set; }

    public string? Dentist { get; set; }

    public string? DentistPhone { get; set; }

    public string? DentistAddress { get; set; }

    public string? InsuranceCompany { get; set; }

    public string? InsurancePolicy { get; set; }

    public string? InsuranceGroup { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? WorkPhone { get; set; }

    public string? Occupation { get; set; }

    public string? Company { get; set; }

    public string? WorkStreet { get; set; }

    public string? WorkCityStateZip { get; set; }

    public string? Fax { get; set; }

    public string? AutoEmailProgressReport { get; set; }

    public bool? DirectoryBlockName { get; set; }

    public bool? DirectoryBlockHomePhone { get; set; }

    public bool? DirectoryBlockAddress { get; set; }

    public bool? DirectoryBlockEmail { get; set; }

    public bool? AutoEmailGradebookZero { get; set; }

    public string? Denomination { get; set; }

    public int? ChurchId { get; set; }

    public string? BaptismChurch { get; set; }

    public string? BaptismCity { get; set; }

    public string? BaptismState { get; set; }

    public string? CommunionChurch { get; set; }

    public string? CommunionCity { get; set; }

    public string? CommunionState { get; set; }

    public string? ConfirmationChurch { get; set; }

    public string? ConfirmationCity { get; set; }

    public string? ConfirmationState { get; set; }

    public string? ReconciliationChurch { get; set; }

    public string? ReconciliationCity { get; set; }

    public string? ReconciliationState { get; set; }

    public bool? LocalChurchMember { get; set; }

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

    public int? NewStudentInquiryId { get; set; }

    public int? NewStudentInquiryChildNumber { get; set; }

    public string? BarMitzvahChurch { get; set; }

    public string? BarMitzvahCity { get; set; }

    public string? BarMitzvahState { get; set; }

    public string? Birthplace { get; set; }

    public string? BirthCity { get; set; }

    public string? BirthState { get; set; }

    public string? BirthCountry { get; set; }

    public float? ExperienceSchool { get; set; }

    public float? ExperienceTotal { get; set; }

    public string? JobCategory { get; set; }

    public string? WorkCity { get; set; }

    public string? WorkState { get; set; }

    public string? WorkZip { get; set; }

    public bool? MatchingGiftEmployer { get; set; }

    public bool? DonorBlock { get; set; }

    public string? Subdivision { get; set; }

    public int? DonorCompanyId { get; set; }

    public string? ParentAlertPreference { get; set; }

    public bool? DirectoryBlockCellPhone { get; set; }

    public bool? ParentAlertHomePhone { get; set; }

    public bool? ParentAlertCellPhone { get; set; }

    public bool? ParentAlertWorkPhone { get; set; }

    public bool? ParentAlertNoText { get; set; }

    public string? CountryCode { get; set; }

    public bool? PicResized { get; set; }

    public string? WorkPhoneExtension { get; set; }

    public string? MedicalNote { get; set; }

    public string? ChatLogin { get; set; }

    public bool? AutoLogin { get; set; }

    public string? BaptismDate { get; set; }

    public string? CommunionDate { get; set; }

    public string? ConfirmationDate { get; set; }

    public string? ReconciliationDate { get; set; }

    public string? BarMitzvahDate { get; set; }

    public byte[]? Pswd { get; set; }

    public string? Username { get; set; }

    public string? PublicSchoolDistrict { get; set; }

    public string? PublicSchoolCounty { get; set; }

    public string? PublicSchoolState { get; set; }

    public string? PublicSchoolLocalSchool { get; set; }

    public string? PublicSchoolCode { get; set; }

    public int? DayCareRateId { get; set; }

    public int? ReducedLunch { get; set; }

    public bool? UnlinkSibling { get; set; }

    public short? LastConfigSchoolId { get; set; }

    public short LoginAttempts { get; set; }

    public DateTime? PasswordResetUrlSendDate { get; set; }

    public bool IsPasswordResetUrlExpired { get; set; }

    public DateTime PasswordCreationDate { get; set; }

    public int? InvalidLoginCount { get; set; }

    public string? LastSchoolLogin { get; set; }

    public int? EnrollmentResponsibilityId { get; set; }

    public bool Deceased { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public string? ImportId { get; set; }

    public string? CryptPayPnguid { get; set; }

    public string? CryptPayOeguid { get; set; }

    public bool AttendanceScheduledOnly { get; set; }

    public string? WorkCountry { get; set; }

    public string? LegacyPersonId { get; set; }

    public DateTime? ResetPasswordDate { get; set; }

    public int PasswordVersion { get; set; }

    public byte StateReducedLunchOption { get; set; }

    public string? BirthCounty { get; set; }

    public string? MaidenName { get; set; }
}
