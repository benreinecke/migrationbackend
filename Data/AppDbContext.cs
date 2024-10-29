using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using web_api_nelnet.Models;

namespace web_api_nelnet.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ASummaryOfTablesExported> ASummaryOfTablesExporteds { get; set; }

    public virtual DbSet<Addressu> Addressus { get; set; }

    public virtual DbSet<AdmissionsBp> AdmissionsBps { get; set; }

    public virtual DbSet<AdmissionsStatus> AdmissionsStatuses { get; set; }

    public virtual DbSet<AttendanceBp> AttendanceBps { get; set; }

    public virtual DbSet<CheckChurchName> CheckChurchNames { get; set; }

    public virtual DbSet<CheckCombinedEmergencyContact> CheckCombinedEmergencyContacts { get; set; }

    public virtual DbSet<CheckDenomination> CheckDenominations { get; set; }

    public virtual DbSet<CheckEthnicity> CheckEthnicities { get; set; }

    public virtual DbSet<CheckRace> CheckRaces { get; set; }

    public virtual DbSet<ClassLessonPlanBp> ClassLessonPlanBps { get; set; }

    public virtual DbSet<ClassesBp> ClassesBps { get; set; }

    public virtual DbSet<CommunityServiceParentBp> CommunityServiceParentBps { get; set; }

    public virtual DbSet<CommunityServiceStudentBp> CommunityServiceStudentBps { get; set; }

    public virtual DbSet<ConversionTranslation> ConversionTranslations { get; set; }

    public virtual DbSet<CourseCorequisitesBp> CourseCorequisitesBps { get; set; }

    public virtual DbSet<CourseEquivalentsBp> CourseEquivalentsBps { get; set; }

    public virtual DbSet<CourseGradelevelsBp> CourseGradelevelsBps { get; set; }

    public virtual DbSet<CoursePrerequisitesBp> CoursePrerequisitesBps { get; set; }

    public virtual DbSet<CoursesBp> CoursesBps { get; set; }

    public virtual DbSet<DisciplineBp> DisciplineBps { get; set; }

    public virtual DbSet<EcverifyRelationship> EcverifyRelationships { get; set; }

    public virtual DbSet<ExemptImmunizationBp> ExemptImmunizationBps { get; set; }

    public virtual DbSet<FamiliesNoCustodian> FamiliesNoCustodians { get; set; }

    public virtual DbSet<FamilyAcctBalanceBp> FamilyAcctBalanceBps { get; set; }

    public virtual DbSet<GrandparentNotMarkedGrandParent> GrandparentNotMarkedGrandParents { get; set; }

    public virtual DbSet<Immunization2Bp> Immunization2Bps { get; set; }

    public virtual DbSet<IndividualNoRight> IndividualNoRights { get; set; }

    public virtual DbSet<InquiriesBp> InquiriesBps { get; set; }

    public virtual DbSet<InvalidAddress> InvalidAddresses { get; set; }

    public virtual DbSet<InvalidDate> InvalidDates { get; set; }

    public virtual DbSet<InvalidPhoneNumber> InvalidPhoneNumbers { get; set; }

    public virtual DbSet<InvalidSchoolCode> InvalidSchoolCodes { get; set; }

    public virtual DbSet<InvalidSsn> InvalidSsns { get; set; }

    public virtual DbSet<LockerBp> LockerBps { get; set; }

    public virtual DbSet<LockerDuplicateNumber> LockerDuplicateNumbers { get; set; }

    public virtual DbSet<MasterLessonPlanBp> MasterLessonPlanBps { get; set; }

    public virtual DbSet<MedicalGeneralAllergyCommentNoAllergy> MedicalGeneralAllergyCommentNoAllergies { get; set; }

    public virtual DbSet<MedicalGeneralBp> MedicalGeneralBps { get; set; }

    public virtual DbSet<MedicalGeneralInvalidDate> MedicalGeneralInvalidDates { get; set; }

    public virtual DbSet<MedicalGeneralMissingInfo> MedicalGeneralMissingInfos { get; set; }

    public virtual DbSet<MedicalGeneralNoLegacyPersonId> MedicalGeneralNoLegacyPersonIds { get; set; }

    public virtual DbSet<MedicalGeneralNoPerson> MedicalGeneralNoPeople { get; set; }

    public virtual DbSet<MigrationStatus> MigrationStatuses { get; set; }

    public virtual DbSet<MissingOrInvalidEmail> MissingOrInvalidEmails { get; set; }

    public virtual DbSet<OtcstudentBp> OtcstudentBps { get; set; }

    public virtual DbSet<ParentBlankLegacyPersonId> ParentBlankLegacyPersonIds { get; set; }

    public virtual DbSet<ParentBlankRelationship> ParentBlankRelationships { get; set; }

    public virtual DbSet<ParentBp> ParentBps { get; set; }

    public virtual DbSet<ParentConfirmCustody> ParentConfirmCustodies { get; set; }

    public virtual DbSet<ParentDuplicateLegacyId> ParentDuplicateLegacyIds { get; set; }

    public virtual DbSet<ParentDuplicatedEmail> ParentDuplicatedEmails { get; set; }

    public virtual DbSet<ParentEmail1andEmail2Match> ParentEmail1andEmail2Matches { get; set; }

    public virtual DbSet<ParentEncodingIssue> ParentEncodingIssues { get; set; }

    public virtual DbSet<ParentGenderIssue> ParentGenderIssues { get; set; }

    public virtual DbSet<ParentInmultipleFamily> ParentInmultipleFamilies { get; set; }

    public virtual DbSet<ParentMissingFirstorLastName> ParentMissingFirstorLastNames { get; set; }

    public virtual DbSet<ParentMissingInvalidPermission> ParentMissingInvalidPermissions { get; set; }

    public virtual DbSet<ParentMissingPhoneNumber> ParentMissingPhoneNumbers { get; set; }

    public virtual DbSet<ParentMissingSalutation> ParentMissingSalutations { get; set; }

    public virtual DbSet<ParentMultipleMotherFather> ParentMultipleMotherFathers { get; set; }

    public virtual DbSet<ParentNoFamilyName> ParentNoFamilyNames { get; set; }

    public virtual DbSet<ParentNoFamilyOrder> ParentNoFamilyOrders { get; set; }

    public virtual DbSet<ParentNoLegacyPersonId> ParentNoLegacyPersonIds { get; set; }

    public virtual DbSet<ParentNoStudent> ParentNoStudents { get; set; }

    public virtual DbSet<ParentPotentialDupe> ParentPotentialDupes { get; set; }

    public virtual DbSet<ParentStateAbbrvNotValid> ParentStateAbbrvNotValids { get; set; }

    public virtual DbSet<ProdDataTimeStamp> ProdDataTimeStamps { get; set; }

    public virtual DbSet<RaceBp> RaceBps { get; set; }

    public virtual DbSet<RosterBp> RosterBps { get; set; }

    public virtual DbSet<Rwaddress> Rwaddresses { get; set; }

    public virtual DbSet<Rwclass> Rwclasses { get; set; }

    public virtual DbSet<RwconfigSchool> RwconfigSchools { get; set; }

    public virtual DbSet<Rwcourse> Rwcourses { get; set; }

    public virtual DbSet<RwcourseLevel> RwcourseLevels { get; set; }

    public virtual DbSet<RwcourseLevelLetterGrade> RwcourseLevelLetterGrades { get; set; }

    public virtual DbSet<RwcourseLevelNumberGrade> RwcourseLevelNumberGrades { get; set; }

    public virtual DbSet<Rwdefinedlist> Rwdefinedlists { get; set; }

    public virtual DbSet<RwfamilyConfig> RwfamilyConfigs { get; set; }

    public virtual DbSet<RwgradeLevel> RwgradeLevels { get; set; }

    public virtual DbSet<RwparentStudent> RwparentStudents { get; set; }

    public virtual DbSet<Rwperson> Rwpeople { get; set; }

    public virtual DbSet<RwpersonFamily> RwpersonFamilies { get; set; }

    public virtual DbSet<RwschedulePattern> RwschedulePatterns { get; set; }

    public virtual DbSet<RwscheduleTemplate> RwscheduleTemplates { get; set; }

    public virtual DbSet<RwschoolTerm> RwschoolTerms { get; set; }

    public virtual DbSet<RwschoolYear> RwschoolYears { get; set; }

    public virtual DbSet<Rwstaff> Rwstaffs { get; set; }

    public virtual DbSet<Rwstudent> Rwstudents { get; set; }

    public virtual DbSet<RwstudentRank> RwstudentRanks { get; set; }

    public virtual DbSet<Rwudfield> Rwudfields { get; set; }

    public virtual DbSet<RwudfieldDefinedList> RwudfieldDefinedLists { get; set; }

    public virtual DbSet<Rwudgroup> Rwudgroups { get; set; }

    public virtual DbSet<SkillSetBp> SkillSetBps { get; set; }

    public virtual DbSet<StaffBp> StaffBps { get; set; }

    public virtual DbSet<StaffDenominationNotDefined> StaffDenominationNotDefineds { get; set; }

    public virtual DbSet<StaffDuplicateId> StaffDuplicateIds { get; set; }

    public virtual DbSet<StaffEmailandEmail2Match> StaffEmailandEmail2Matches { get; set; }

    public virtual DbSet<StaffEncodingIssue> StaffEncodingIssues { get; set; }

    public virtual DbSet<StaffGenderNotInStandard> StaffGenderNotInStandards { get; set; }

    public virtual DbSet<StaffInvalidActiveStatus> StaffInvalidActiveStatuses { get; set; }

    public virtual DbSet<StaffInvalidDate> StaffInvalidDates { get; set; }

    public virtual DbSet<StaffInvalidElem> StaffInvalidElems { get; set; }

    public virtual DbSet<StaffInvalidExperienceSchool> StaffInvalidExperienceSchools { get; set; }

    public virtual DbSet<StaffInvalidExperienceTotal> StaffInvalidExperienceTotals { get; set; }

    public virtual DbSet<StaffInvalidFaculty> StaffInvalidFaculties { get; set; }

    public virtual DbSet<StaffInvalidFullTime> StaffInvalidFullTimes { get; set; }

    public virtual DbSet<StaffInvalidH> StaffInvalidHs { get; set; }

    public virtual DbSet<StaffInvalidM> StaffInvalidMs { get; set; }

    public virtual DbSet<StaffInvalidP> StaffInvalidPs { get; set; }

    public virtual DbSet<StaffInvalidStaff> StaffInvalidStaffs { get; set; }

    public virtual DbSet<StaffMissingFirstorLastName> StaffMissingFirstorLastNames { get; set; }

    public virtual DbSet<StaffMissingOccupation> StaffMissingOccupations { get; set; }

    public virtual DbSet<StaffNoFacultyStaffFlag> StaffNoFacultyStaffFlags { get; set; }

    public virtual DbSet<StaffNoFamilyName> StaffNoFamilyNames { get; set; }

    public virtual DbSet<StaffNoFirstName> StaffNoFirstNames { get; set; }

    public virtual DbSet<StaffNoGradeLevelsAssigned> StaffNoGradeLevelsAssigneds { get; set; }

    public virtual DbSet<StaffNoLastName> StaffNoLastNames { get; set; }

    public virtual DbSet<StaffNoLegacyPersonId> StaffNoLegacyPersonIds { get; set; }

    public virtual DbSet<StaffOccupationNotInDefaultList> StaffOccupationNotInDefaultLists { get; set; }

    public virtual DbSet<StaffPotentialParent> StaffPotentialParents { get; set; }

    public virtual DbSet<StaffRaceNotInStandard> StaffRaceNotInStandards { get; set; }

    public virtual DbSet<StaffStateAbbrvNotValid> StaffStateAbbrvNotValids { get; set; }

    public virtual DbSet<StaffcertsBp> StaffcertsBps { get; set; }

    public virtual DbSet<StaffecBp> StaffecBps { get; set; }

    public virtual DbSet<StandAloneAlert> StandAloneAlerts { get; set; }

    public virtual DbSet<StateIdlegacyPersonIdnotFound> StateIdlegacyPersonIdnotFounds { get; set; }

    public virtual DbSet<StateidBp> StateidBps { get; set; }

    public virtual DbSet<StudentAdrNotMatchCustodian> StudentAdrNotMatchCustodians { get; set; }

    public virtual DbSet<StudentBp> StudentBps { get; set; }

    public virtual DbSet<StudentCellPhoneinParentDatum> StudentCellPhoneinParentData { get; set; }

    public virtual DbSet<StudentDuplicateLegacyId> StudentDuplicateLegacyIds { get; set; }

    public virtual DbSet<StudentDuplicateSchoolid> StudentDuplicateSchoolids { get; set; }

    public virtual DbSet<StudentEmail1andEmail2Match> StudentEmail1andEmail2Matches { get; set; }

    public virtual DbSet<StudentEmailinParentDatum> StudentEmailinParentData { get; set; }

    public virtual DbSet<StudentEthnicityNotStandard> StudentEthnicityNotStandards { get; set; }

    public virtual DbSet<StudentGenderNotInStandard> StudentGenderNotInStandards { get; set; }

    public virtual DbSet<StudentIllogicalSacramentDate> StudentIllogicalSacramentDates { get; set; }

    public virtual DbSet<StudentInParent> StudentInParents { get; set; }

    public virtual DbSet<StudentInvalidGradeLevel> StudentInvalidGradeLevels { get; set; }

    public virtual DbSet<StudentInvalidStatus> StudentInvalidStatuses { get; set; }

    public virtual DbSet<StudentMissingBirthdate> StudentMissingBirthdates { get; set; }

    public virtual DbSet<StudentMissingEnrollDate> StudentMissingEnrollDates { get; set; }

    public virtual DbSet<StudentMissingFirstorLastName> StudentMissingFirstorLastNames { get; set; }

    public virtual DbSet<StudentMissingGender> StudentMissingGenders { get; set; }

    public virtual DbSet<StudentNoFamily> StudentNoFamilies { get; set; }

    public virtual DbSet<StudentNoGradeLevel> StudentNoGradeLevels { get; set; }

    public virtual DbSet<StudentReducedLunchNotFormatted> StudentReducedLunchNotFormatteds { get; set; }

    public virtual DbSet<StudentStateAbbrvNotValid> StudentStateAbbrvNotValids { get; set; }

    public virtual DbSet<StudentTransportationBp> StudentTransportationBps { get; set; }

    public virtual DbSet<TranscriptsBp> TranscriptsBps { get; set; }

    public virtual DbSet<UdconfigBp> UdconfigBps { get; set; }

    public virtual DbSet<UddataBp> UddataBps { get; set; }

    public virtual DbSet<UddataNotDefined> UddataNotDefineds { get; set; }

    public virtual DbSet<ValidationConfiguration> ValidationConfigurations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:nelnet-test-server.database.windows.net,1433;Initial Catalog=Development Database;Persist Security Info=False;User ID=sysadmin;Password=s1s4dm1n.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ASummaryOfTablesExported>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A_Summary_of_Tables_Exported", "val");

            entity.Property(e => e.AddUpdatesToBoiler)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Add_Updates_to_Boiler");
            entity.Property(e => e.Required)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Required?");
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<Addressu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ADDRESSU");

            entity.Property(e => e.Address1).HasMaxLength(200);
            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .HasColumnName("address2");
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .HasColumnName("state");
            entity.Property(e => e.Zip)
                .HasMaxLength(25)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<AdmissionsBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Admissio__360414FF193D5167");

            entity.ToTable("AdmissionsBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.AdmissionsNotes).HasMaxLength(255);
            entity.Property(e => e.Applicationdate).HasMaxLength(255);
            entity.Property(e => e.Applicationstatus).HasMaxLength(255);
            entity.Property(e => e.AutoLicense).HasMaxLength(255);
            entity.Property(e => e.BaptismChurch).HasMaxLength(255);
            entity.Property(e => e.BaptismCity).HasMaxLength(255);
            entity.Property(e => e.BaptismDate).HasMaxLength(255);
            entity.Property(e => e.BaptismState).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahChurch).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahCity).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahDate).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahState).HasMaxLength(255);
            entity.Property(e => e.BirthCity).HasMaxLength(255);
            entity.Property(e => e.BirthCountry).HasMaxLength(255);
            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.BirthState).HasMaxLength(255);
            entity.Property(e => e.BloodType).HasMaxLength(255);
            entity.Property(e => e.Cancelreason).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Church).HasMaxLength(255);
            entity.Property(e => e.Citizenship).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.ClassOf).HasMaxLength(255);
            entity.Property(e => e.CommunionChurch).HasMaxLength(255);
            entity.Property(e => e.CommunionCity).HasMaxLength(255);
            entity.Property(e => e.CommunionDate).HasMaxLength(255);
            entity.Property(e => e.CommunionState).HasMaxLength(255);
            entity.Property(e => e.ConfirmationChurch).HasMaxLength(255);
            entity.Property(e => e.ConfirmationCity).HasMaxLength(255);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(255);
            entity.Property(e => e.ConfirmationState).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.Dentist).HasMaxLength(255);
            entity.Property(e => e.DentistAddress).HasMaxLength(255);
            entity.Property(e => e.DentistPhone).HasMaxLength(255);
            entity.Property(e => e.Doctor).HasMaxLength(255);
            entity.Property(e => e.DrAddress).HasMaxLength(255);
            entity.Property(e => e.DrPhone).HasMaxLength(255);
            entity.Property(e => e.DriverLicense).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2)
                .HasMaxLength(255)
                .HasColumnName("EMAIL2");
            entity.Property(e => e.Enrollmentpackstarted).HasMaxLength(255);
            entity.Property(e => e.Enrollmentpacksubmitted).HasMaxLength(255);
            entity.Property(e => e.Ernollmentpacksent).HasMaxLength(255);
            entity.Property(e => e.Ethnicity).HasMaxLength(255);
            entity.Property(e => e.FaepersonId)
                .HasMaxLength(255)
                .HasColumnName("FAEPersonID");
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyNameSecond).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.Hospital).HasMaxLength(255);
            entity.Property(e => e.HospitalAddress).HasMaxLength(255);
            entity.Property(e => e.InsuranceCompany).HasMaxLength(255);
            entity.Property(e => e.InsuranceGroup).HasMaxLength(255);
            entity.Property(e => e.InsurancePolicy).HasMaxLength(255);
            entity.Property(e => e.Interviewdate).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Make).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Model).HasMaxLength(255);
            entity.Property(e => e.NickName).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PermissionToTreat).HasMaxLength(255);
            entity.Property(e => e.PermitNumber).HasMaxLength(255);
            entity.Property(e => e.PreviousSchool).HasMaxLength(255);
            entity.Property(e => e.Primarylanguage).HasMaxLength(255);
            entity.Property(e => e.PublicSchoolCounty).HasMaxLength(255);
            entity.Property(e => e.PublicSchoolDistrict).HasMaxLength(255);
            entity.Property(e => e.Publicschoollocalschool).HasMaxLength(255);
            entity.Property(e => e.Publicschoolstate).HasMaxLength(255);
            entity.Property(e => e.ReconciliationChurch).HasMaxLength(255);
            entity.Property(e => e.ReconciliationCity).HasMaxLength(255);
            entity.Property(e => e.ReconciliationDate).HasMaxLength(255);
            entity.Property(e => e.ReconciliationState).HasMaxLength(255);
            entity.Property(e => e.Reducedlunch).HasMaxLength(255);
            entity.Property(e => e.Referredby).HasMaxLength(255);
            entity.Property(e => e.Referredbydetails).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.SchoolYear).HasMaxLength(255);
            entity.Property(e => e.Ssn)
                .HasMaxLength(255)
                .HasColumnName("SSN");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Suffix).HasMaxLength(255);
            entity.Property(e => e.Testdate)
                .HasMaxLength(255)
                .HasColumnName("TESTDATE");
            entity.Property(e => e.Udstatus)
                .HasMaxLength(255)
                .HasColumnName("UDSTATUS");
            entity.Property(e => e.WithdrawDate).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<AdmissionsStatus>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AdmissionStatus).HasMaxLength(255);
        });

        modelBuilder.Entity<AttendanceBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Attendan__360414FF909A53D8");

            entity.ToTable("AttendanceBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.AttendanceCode).HasMaxLength(255);
            entity.Property(e => e.AttendanceCodeName).HasMaxLength(255);
            entity.Property(e => e.AttendanceDate).HasMaxLength(255);
            entity.Property(e => e.Column).HasMaxLength(255);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Section).HasMaxLength(255);
        });

        modelBuilder.Entity<CheckChurchName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckChurchNames", "val");

            entity.Property(e => e.NewValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasMaxLength(255);
            entity.Property(e => e.ValueCategory)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CheckCombinedEmergencyContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckCombinedEmergencyContact", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<CheckDenomination>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckDenominations", "val");

            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.InDefinedList)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("In Defined List?");
            entity.Property(e => e.NewValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ValueCategory)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CheckEthnicity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckEthnicity", "val");

            entity.Property(e => e.Ethnicity).HasMaxLength(255);
            entity.Property(e => e.InDefinedList)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("In Defined List?");
            entity.Property(e => e.NewValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ValueCategory)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CheckRace>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckRace", "val");

            entity.Property(e => e.InDefinedList)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("In Defined List?");
            entity.Property(e => e.NewValue)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Race).HasMaxLength(255);
            entity.Property(e => e.ValueCategory)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClassLessonPlanBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__ClassLes__360414FFC7EE3094");

            entity.ToTable("ClassLessonPlanBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.Homework).HasMaxLength(255);
            entity.Property(e => e.LessonPlan).HasMaxLength(255);
            entity.Property(e => e.PlanDate).HasMaxLength(255);
            entity.Property(e => e.Section).HasMaxLength(255);
            entity.Property(e => e.Text1).HasMaxLength(255);
            entity.Property(e => e.Text2).HasMaxLength(255);
            entity.Property(e => e.Text3).HasMaxLength(255);
            entity.Property(e => e.Text4).HasMaxLength(255);
        });

        modelBuilder.Entity<ClassesBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__ClassesB__360414FF7B9BD557");

            entity.ToTable("ClassesBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.AltFirstName).HasMaxLength(255);
            entity.Property(e => e.AltLastName).HasMaxLength(255);
            entity.Property(e => e.AltLegacyPersonid).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Legacyclassid).HasMaxLength(255);
            entity.Property(e => e.Legacypersonid).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.Pattern).HasMaxLength(255);
            entity.Property(e => e.Room).HasMaxLength(255);
            entity.Property(e => e.Section).HasMaxLength(255);
            entity.Property(e => e.Template).HasMaxLength(255);
            entity.Property(e => e.Term1).HasMaxLength(255);
            entity.Property(e => e.Term2).HasMaxLength(255);
            entity.Property(e => e.Term3).HasMaxLength(255);
            entity.Property(e => e.Term4).HasMaxLength(255);
            entity.Property(e => e.Term5).HasMaxLength(255);
            entity.Property(e => e.Term6).HasMaxLength(255);
            entity.Property(e => e.YearId)
                .HasMaxLength(255)
                .HasColumnName("YearID");
        });

        modelBuilder.Entity<CommunityServiceParentBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Communit__360414FF3B411256");

            entity.ToTable("CommunityServiceParentBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Day).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HoursWorked).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.YearId)
                .HasMaxLength(255)
                .HasColumnName("YearID");
        });

        modelBuilder.Entity<CommunityServiceStudentBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Communit__360414FFB8E28310");

            entity.ToTable("CommunityServiceStudentBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Day).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.HoursWorked).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
        });

        modelBuilder.Entity<ConversionTranslation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("conversion_Translation");

            entity.HasIndex(e => new { e.Type, e.From, e.To }, "Unique_Translation").IsUnique();

            entity.Property(e => e.From).HasMaxLength(150);
            entity.Property(e => e.To)
                .HasMaxLength(2000)
                .HasDefaultValue("");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<CourseCorequisitesBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Course_C__360414FF4A793F3E");

            entity.ToTable("Course_CorequisitesBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.CoreqAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Coreq_Abbreviation");
            entity.Property(e => e.CoreqCourseId)
                .HasMaxLength(255)
                .HasColumnName("Coreq_CourseID");
            entity.Property(e => e.CourseId)
                .HasMaxLength(255)
                .HasColumnName("CourseID");
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
        });

        modelBuilder.Entity<CourseEquivalentsBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Course_E__360414FF741EC754");

            entity.ToTable("Course_EquivalentsBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.CourseId)
                .HasMaxLength(255)
                .HasColumnName("CourseID");
            entity.Property(e => e.EquivalentAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Equivalent_Abbreviation");
            entity.Property(e => e.EquivalentCourseId)
                .HasMaxLength(255)
                .HasColumnName("Equivalent_CourseID");
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
        });

        modelBuilder.Entity<CourseGradelevelsBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Course_G__360414FFDA71A885");

            entity.ToTable("Course_GradelevelsBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.CourseId)
                .HasMaxLength(255)
                .HasColumnName("CourseID");
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<CoursePrerequisitesBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Course_P__360414FF7D3A6A9A");

            entity.ToTable("Course_PrerequisitesBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.CourseId)
                .HasMaxLength(255)
                .HasColumnName("CourseID");
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.PrereqAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Prereq_Abbreviation");
            entity.Property(e => e.PrereqCourseId)
                .HasMaxLength(255)
                .HasColumnName("Prereq_CourseID");
        });

        modelBuilder.Entity<CoursesBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__CoursesB__360414FF03F1EEE7");

            entity.ToTable("CoursesBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.Active).HasMaxLength(255);
            entity.Property(e => e.Activity).HasMaxLength(255);
            entity.Property(e => e.Attendance).HasMaxLength(255);
            entity.Property(e => e.Calc).HasMaxLength(255);
            entity.Property(e => e.CourseLevel).HasMaxLength(255);
            entity.Property(e => e.Credits).HasMaxLength(255);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.Elective).HasMaxLength(255);
            entity.Property(e => e.Elementary).HasMaxLength(255);
            entity.Property(e => e.Homeroom).HasMaxLength(255);
            entity.Property(e => e.Hs)
                .HasMaxLength(255)
                .HasColumnName("HS");
            entity.Property(e => e.LegacyCourseId)
                .HasMaxLength(255)
                .HasColumnName("LegacyCourseID");
            entity.Property(e => e.MaxSize).HasMaxLength(255);
            entity.Property(e => e.MiddleSchool).HasMaxLength(255);
            entity.Property(e => e.NoCalcTranscript).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.PreSchool).HasMaxLength(255);
            entity.Property(e => e.Rcplacement)
                .HasMaxLength(255)
                .HasColumnName("RCPlacement");
            entity.Property(e => e.ReportCard).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.StateId)
                .HasMaxLength(255)
                .HasColumnName("StateID");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.TranscriptLoad).HasMaxLength(255);
            entity.Property(e => e.Weight).HasMaxLength(255);
        });

        modelBuilder.Entity<DisciplineBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Discipli__360414FF38861C5A");

            entity.ToTable("DisciplineBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.DateOfIncident).HasMaxLength(255);
            entity.Property(e => e.Demerits).HasMaxLength(255);
            entity.Property(e => e.DescriptionOfIncident).HasMaxLength(255);
            entity.Property(e => e.History).HasMaxLength(255);
            entity.Property(e => e.Level).HasMaxLength(255);
            entity.Property(e => e.Sanction1).HasMaxLength(255);
            entity.Property(e => e.Sanction2).HasMaxLength(255);
            entity.Property(e => e.SanctionDate1).HasMaxLength(255);
            entity.Property(e => e.SanctionDate2).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(255)
                .HasColumnName("StaffID");
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.Violation).HasMaxLength(255);
        });

        modelBuilder.Entity<EcverifyRelationship>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ECVerifyRelationship", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ExemptImmunizationBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__ExemptIm__360414FF951B2DFF");

            entity.ToTable("ExemptImmunizationBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Dtp0)
                .HasMaxLength(255)
                .HasColumnName("DTP:0");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HepA0)
                .HasMaxLength(255)
                .HasColumnName("Hep A:0");
            entity.Property(e => e.HepB0)
                .HasMaxLength(255)
                .HasColumnName("Hep B:0");
            entity.Property(e => e.Hib0)
                .HasMaxLength(255)
                .HasColumnName("Hib:0");
            entity.Property(e => e.Hpv0)
                .HasMaxLength(255)
                .HasColumnName("HPV:0");
            entity.Property(e => e.Influezena0)
                .HasMaxLength(255)
                .HasColumnName("Influezena:0");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MenAcwy0)
                .HasMaxLength(255)
                .HasColumnName("MenACWY:0");
            entity.Property(e => e.MenB0)
                .HasMaxLength(255)
                .HasColumnName("Men B:0");
            entity.Property(e => e.Mmr0)
                .HasMaxLength(255)
                .HasColumnName("MMR:0");
            entity.Property(e => e.Pneumococcal0)
                .HasMaxLength(255)
                .HasColumnName("Pneumococcal:0");
            entity.Property(e => e.Polio0)
                .HasMaxLength(255)
                .HasColumnName("Polio:0");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
            entity.Property(e => e.Tdap0)
                .HasMaxLength(255)
                .HasColumnName("Tdap:0");
            entity.Property(e => e.Varicella0)
                .HasMaxLength(255)
                .HasColumnName("Varicella:0");
        });

        modelBuilder.Entity<FamiliesNoCustodian>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FamiliesNoCustodians", "val");

            entity.Property(e => e.Correspondence).HasMaxLength(255);
            entity.Property(e => e.Custody).HasMaxLength(255);
            entity.Property(e => e.EmergencyContact).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FinancialResponsibility).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Grandparent).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.ParentsWeb).HasMaxLength(255);
            entity.Property(e => e.Pickup).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.ReportCard).HasMaxLength(255);
        });

        modelBuilder.Entity<FamilyAcctBalanceBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__FamilyAc__360414FF364E698F");

            entity.ToTable("FamilyAcctBalanceBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Balance).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FiscalYearName).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<GrandparentNotMarkedGrandParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GrandparentNotMarkedGrandParent", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Grandparent).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<Immunization2Bp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Immuniza__360414FF5EBEA86F");

            entity.ToTable("Immunization2BP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Exemption).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.ShotDate).HasMaxLength(255);
            entity.Property(e => e.ShotNote).HasMaxLength(255);
            entity.Property(e => e.ShotNumber).HasMaxLength(255);
            entity.Property(e => e.ShotType).HasMaxLength(255);
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
        });

        modelBuilder.Entity<IndividualNoRight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndividualNoRights", "val");

            entity.Property(e => e.Correspondence).HasMaxLength(255);
            entity.Property(e => e.Custody).HasMaxLength(255);
            entity.Property(e => e.EmergencyContact).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FinancialResponsibility).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Grandparent).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.ParentsWeb).HasMaxLength(255);
            entity.Property(e => e.Pickup).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.ReportCard).HasMaxLength(255);
        });

        modelBuilder.Entity<InquiriesBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Inquirie__360414FF3FCB837B");

            entity.ToTable("InquiriesBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.ApplicantRating).HasMaxLength(255);
            entity.Property(e => e.ApplicantRatingNotes).HasMaxLength(255);
            entity.Property(e => e.CampusVisitDate).HasMaxLength(255);
            entity.Property(e => e.CurrentSchool).HasMaxLength(255);
            entity.Property(e => e.DiscoveryMethod).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.InquiryDate).HasMaxLength(255);
            entity.Property(e => e.InquiryId)
                .HasMaxLength(255)
                .HasColumnName("InquiryID");
            entity.Property(e => e.InquiryManagement).HasMaxLength(255);
            entity.Property(e => e.Language).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Parent1Email).HasMaxLength(255);
            entity.Property(e => e.Parent1FirstName).HasMaxLength(255);
            entity.Property(e => e.Parent1Gender).HasMaxLength(255);
            entity.Property(e => e.Parent1LastName).HasMaxLength(255);
            entity.Property(e => e.Parent1MiddleName).HasMaxLength(255);
            entity.Property(e => e.Parent1Phone).HasMaxLength(255);
            entity.Property(e => e.Parent2Email).HasMaxLength(255);
            entity.Property(e => e.Parent2FirstName).HasMaxLength(255);
            entity.Property(e => e.Parent2Gender).HasMaxLength(255);
            entity.Property(e => e.Parent2LastName).HasMaxLength(255);
            entity.Property(e => e.Parent2MiddleName).HasMaxLength(255);
            entity.Property(e => e.Parent2Phone).HasMaxLength(255);
            entity.Property(e => e.ParentNotes).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolYear).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.SubStatus).HasMaxLength(255);
        });

        modelBuilder.Entity<InvalidAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvalidAddress", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<InvalidDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvalidDates", "val");

            entity.Property(e => e.Date).HasMaxLength(255);
            entity.Property(e => e.Field)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecId).HasColumnName("RecID");
        });

        modelBuilder.Entity<InvalidPhoneNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvalidPhoneNumbers", "val");

            entity.Property(e => e.Field)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.RecId).HasColumnName("RecID");
        });

        modelBuilder.Entity<InvalidSchoolCode>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("InvalidSchoolCode", "val");

            entity.Property(e => e.RecId)
                .ValueGeneratedNever()
                .HasColumnName("RecID");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<InvalidSsn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvalidSSN", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Ssn)
                .HasMaxLength(255)
                .HasColumnName("SSN");
        });

        modelBuilder.Entity<LockerBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__LockerBP__360414FFD6E406D4");

            entity.ToTable("LockerBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Combo1).HasMaxLength(255);
            entity.Property(e => e.Combo2).HasMaxLength(255);
            entity.Property(e => e.Combo3).HasMaxLength(255);
            entity.Property(e => e.Combo4).HasMaxLength(255);
            entity.Property(e => e.Combo5).HasMaxLength(255);
            entity.Property(e => e.CurrentCombo).HasMaxLength(255);
            entity.Property(e => e.Locker).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<LockerDuplicateNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LockerDuplicateNumber", "val");

            entity.Property(e => e.Locker).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<MasterLessonPlanBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__MasterLe__360414FFDFCD9793");

            entity.ToTable("MasterLessonPlanBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.Day).HasMaxLength(255);
            entity.Property(e => e.Details1).HasMaxLength(255);
            entity.Property(e => e.Details2).HasMaxLength(255);
            entity.Property(e => e.Details3).HasMaxLength(255);
            entity.Property(e => e.Details4).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Homework).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LessonPlan).HasMaxLength(255);
        });

        modelBuilder.Entity<MedicalGeneralAllergyCommentNoAllergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MedicalGeneralAllergyCommentNoAllergy", "val");

            entity.Property(e => e.Allergy).HasMaxLength(255);
            entity.Property(e => e.AllergyComment).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<MedicalGeneralBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__MedicalG__360414FF4DF3BED4");

            entity.ToTable("MedicalGeneralBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Allergy).HasMaxLength(255);
            entity.Property(e => e.AllergyComment).HasMaxLength(255);
            entity.Property(e => e.Condition).HasMaxLength(255);
            entity.Property(e => e.ConditionComment).HasMaxLength(255);
            entity.Property(e => e.DatePrescribed).HasMaxLength(255);
            entity.Property(e => e.Dose).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Medication).HasMaxLength(255);
            entity.Property(e => e.MedicationComment).HasMaxLength(255);
            entity.Property(e => e.Scheduled).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.SelfAdminister).HasMaxLength(255);
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
        });

        modelBuilder.Entity<MedicalGeneralInvalidDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MedicalGeneralInvalidDates", "val");

            entity.Property(e => e.DatePrescribed).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<MedicalGeneralMissingInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MedicalGeneralMissingInfo", "val");

            entity.Property(e => e.Allergy).HasMaxLength(255);
            entity.Property(e => e.Condition).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Medication).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<MedicalGeneralNoLegacyPersonId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MedicalGeneralNoLegacyPersonID", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<MedicalGeneralNoPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MedicalGeneralNoPerson", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
        });

        modelBuilder.Entity<MigrationStatus>(entity =>
        {
            entity.HasKey(e => new { e.Step, e.Id, e.Name }).HasName("PK__migration_status");

            entity.ToTable("__migration_status");

            entity.Property(e => e.Step).HasColumnName("STEP");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME");
            entity.Property(e => e.Action).HasColumnName("ACTION");
            entity.Property(e => e.Dbname)
                .HasMaxLength(128)
                .HasColumnName("DBNAME");
            entity.Property(e => e.Fullname)
                .HasMaxLength(128)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.IsMemoryOptimized).HasColumnName("is_memory_optimized");
            entity.Property(e => e.Kbs).HasColumnName("KBS");
            entity.Property(e => e.Nrows).HasColumnName("NROWS");
            entity.Property(e => e.Partition).HasColumnName("partition");
            entity.Property(e => e.Rollback).HasColumnName("ROLLBACK");
            entity.Property(e => e.Schema)
                .HasMaxLength(128)
                .HasColumnName("SCHEMA");
            entity.Property(e => e.Tablename)
                .HasMaxLength(128)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<MissingOrInvalidEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MissingOrInvalidEmails", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Field)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecId).HasColumnName("RecID");
        });

        modelBuilder.Entity<OtcstudentBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__OTCStude__360414FF5E2F0773");

            entity.ToTable("OTCStudentBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Otcmedication)
                .HasMaxLength(255)
                .HasColumnName("OTCMedication");
            entity.Property(e => e.Schoolcode).HasMaxLength(255);
            entity.Property(e => e.Schoolid).HasMaxLength(255);
            entity.Property(e => e.SelfAdminister).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentBlankLegacyPersonId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentBlankLegacyPersonID", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentBlankRelationship>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentBlankRelationships", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__ParentBP__360414FF4B8360F1");

            entity.ToTable("ParentBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.BachelorDegree).HasMaxLength(255);
            entity.Property(e => e.BachelorDegree2).HasMaxLength(255);
            entity.Property(e => e.BachelorSchool).HasMaxLength(255);
            entity.Property(e => e.BachelorSchool2).HasMaxLength(255);
            entity.Property(e => e.BachelorYear).HasMaxLength(255);
            entity.Property(e => e.BachelorYear2).HasMaxLength(255);
            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Church).HasMaxLength(255);
            entity.Property(e => e.Citizenship).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Company).HasMaxLength(255);
            entity.Property(e => e.Correspondence).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Custody).HasMaxLength(255);
            entity.Property(e => e.Deceased).HasMaxLength(255);
            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.DriverLicense).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.EmergencyContact).HasMaxLength(255);
            entity.Property(e => e.FaepersonId)
                .HasMaxLength(255)
                .HasColumnName("FAEPersonID");
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyOrder).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.FinancialResponsibility).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Grandparent).HasMaxLength(255);
            entity.Property(e => e.HighSchool).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MaritalStatus).HasMaxLength(255);
            entity.Property(e => e.MasterDegree).HasMaxLength(255);
            entity.Property(e => e.MasterDegree2).HasMaxLength(255);
            entity.Property(e => e.MasterSchool).HasMaxLength(255);
            entity.Property(e => e.MasterSchool2).HasMaxLength(255);
            entity.Property(e => e.MasterYear).HasMaxLength(255);
            entity.Property(e => e.MasterYear2).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Nickname).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Occupation).HasMaxLength(255);
            entity.Property(e => e.ParentsWeb).HasMaxLength(255);
            entity.Property(e => e.Phddegree)
                .HasMaxLength(255)
                .HasColumnName("PHDDegree");
            entity.Property(e => e.Phddegree2)
                .HasMaxLength(255)
                .HasColumnName("PHDDegree2");
            entity.Property(e => e.Phdschool)
                .HasMaxLength(255)
                .HasColumnName("PHDSchool");
            entity.Property(e => e.Phdschool2)
                .HasMaxLength(255)
                .HasColumnName("PHDSchool2");
            entity.Property(e => e.Phdyear)
                .HasMaxLength(255)
                .HasColumnName("PHDYear");
            entity.Property(e => e.Phdyear2)
                .HasMaxLength(255)
                .HasColumnName("PHDYear2");
            entity.Property(e => e.Pickup).HasMaxLength(255);
            entity.Property(e => e.Portalsortorder).HasMaxLength(255);
            entity.Property(e => e.Primarylanguage).HasMaxLength(255);
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.ReportCard).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e.Ssn)
                .HasMaxLength(255)
                .HasColumnName("SSN");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Suffix).HasMaxLength(255);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.WorkCity).HasMaxLength(255);
            entity.Property(e => e.WorkPhone).HasMaxLength(255);
            entity.Property(e => e.WorkPhoneExtension).HasMaxLength(255);
            entity.Property(e => e.WorkState).HasMaxLength(255);
            entity.Property(e => e.WorkStreet).HasMaxLength(255);
            entity.Property(e => e.WorkZip).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentConfirmCustody>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentConfirmCustody", "val");

            entity.Property(e => e.Custody).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentDuplicateLegacyId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentDuplicateLegacyID", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentDuplicatedEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentDuplicatedEmails", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentEmail1andEmail2Match>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentEmail1andEmail2Match", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentEncodingIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentEncodingIssues", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentGenderIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentGenderIssues", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Issue)
                .HasMaxLength(33)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e._)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName(" ");
        });

        modelBuilder.Entity<ParentInmultipleFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentInmultipleFamilies", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentMissingFirstorLastName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentMissingFirstorLastName", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyOrder).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentMissingInvalidPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentMissingInvalidPermissions", "val");

            entity.Property(e => e.Correspondence).HasMaxLength(255);
            entity.Property(e => e.Custody).HasMaxLength(255);
            entity.Property(e => e.EmergencyContact).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FinancialResponsibility).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Grandparent).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.ParentsWeb).HasMaxLength(255);
            entity.Property(e => e.Pickup).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.ReportCard).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentMissingPhoneNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentMissingPhoneNumber", "val");

            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentMissingSalutation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentMissingSalutations", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e.Suffix).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentMultipleMotherFather>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentMultipleMotherFather", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentNoFamilyName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentNoFamilyName", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentNoFamilyOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentNoFamilyOrder", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyOrder).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentNoLegacyPersonId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentNoLegacyPersonID", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentNoStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentNoStudents", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ParentPotentialDupe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentPotentialDupe", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.WorkPhone).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentStateAbbrvNotValid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParentStateAbbrvNotValid", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<ProdDataTimeStamp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProdDataTimeStamp");

            entity.Property(e => e.TimeOfPull).HasColumnType("datetime");
        });

        modelBuilder.Entity<RaceBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__RaceBP__360414FFF97CE8CF");

            entity.ToTable("RaceBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Race).HasMaxLength(255);
            entity.Property(e => e.Schoolid).HasMaxLength(255);
            entity.Property(e => e.Studentid).HasMaxLength(255);
        });

        modelBuilder.Entity<RosterBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__RosterBP__360414FF9DEBE0C1");

            entity.ToTable("RosterBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.Citizen1).HasMaxLength(255);
            entity.Property(e => e.Citizen2).HasMaxLength(255);
            entity.Property(e => e.Citizen3).HasMaxLength(255);
            entity.Property(e => e.Citizen4).HasMaxLength(255);
            entity.Property(e => e.Citizen5).HasMaxLength(255);
            entity.Property(e => e.Citizen6).HasMaxLength(255);
            entity.Property(e => e.Com1).HasMaxLength(255);
            entity.Property(e => e.Com2).HasMaxLength(255);
            entity.Property(e => e.Com3).HasMaxLength(255);
            entity.Property(e => e.Com4).HasMaxLength(255);
            entity.Property(e => e.Com5).HasMaxLength(255);
            entity.Property(e => e.Com6).HasMaxLength(255);
            entity.Property(e => e.Enrolled).HasMaxLength(255);
            entity.Property(e => e.Enrolled1).HasMaxLength(255);
            entity.Property(e => e.Enrolled2).HasMaxLength(255);
            entity.Property(e => e.Enrolled3).HasMaxLength(255);
            entity.Property(e => e.Enrolled4).HasMaxLength(255);
            entity.Property(e => e.Enrolled5).HasMaxLength(255);
            entity.Property(e => e.Enrolled6).HasMaxLength(255);
            entity.Property(e => e.Exam1Avg).HasMaxLength(255);
            entity.Property(e => e.Exam2Avg).HasMaxLength(255);
            entity.Property(e => e.FinalGrade).HasMaxLength(255);
            entity.Property(e => e.FinalGradeAvg).HasMaxLength(255);
            entity.Property(e => e.Grade1).HasMaxLength(255);
            entity.Property(e => e.Grade2).HasMaxLength(255);
            entity.Property(e => e.Grade3).HasMaxLength(255);
            entity.Property(e => e.Grade4).HasMaxLength(255);
            entity.Property(e => e.Grade5).HasMaxLength(255);
            entity.Property(e => e.Grade6).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.Prc1)
                .HasMaxLength(255)
                .HasColumnName("PRC1");
            entity.Property(e => e.Prc2)
                .HasMaxLength(255)
                .HasColumnName("PRC2");
            entity.Property(e => e.Prc3)
                .HasMaxLength(255)
                .HasColumnName("PRC3");
            entity.Property(e => e.Prc4)
                .HasMaxLength(255)
                .HasColumnName("PRC4");
            entity.Property(e => e.Prc5)
                .HasMaxLength(255)
                .HasColumnName("PRC5");
            entity.Property(e => e.Prc6)
                .HasMaxLength(255)
                .HasColumnName("PRC6");
            entity.Property(e => e.Prg1)
                .HasMaxLength(255)
                .HasColumnName("PRG1");
            entity.Property(e => e.Prg2)
                .HasMaxLength(255)
                .HasColumnName("PRG2");
            entity.Property(e => e.Prg3)
                .HasMaxLength(255)
                .HasColumnName("PRG3");
            entity.Property(e => e.Prg4)
                .HasMaxLength(255)
                .HasColumnName("PRG4");
            entity.Property(e => e.Prg5)
                .HasMaxLength(255)
                .HasColumnName("PRG5");
            entity.Property(e => e.Prg6)
                .HasMaxLength(255)
                .HasColumnName("PRG6");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Section).HasMaxLength(255);
            entity.Property(e => e.Sem1Avg).HasMaxLength(255);
            entity.Property(e => e.Sem1Exam).HasMaxLength(255);
            entity.Property(e => e.Sem1Grade).HasMaxLength(255);
            entity.Property(e => e.Sem2Avg).HasMaxLength(255);
            entity.Property(e => e.Sem2Exam).HasMaxLength(255);
            entity.Property(e => e.Sem2Grade).HasMaxLength(255);
            entity.Property(e => e.Term1Avg).HasMaxLength(255);
            entity.Property(e => e.Term2Avg).HasMaxLength(255);
            entity.Property(e => e.Term3Avg).HasMaxLength(255);
            entity.Property(e => e.Term4Avg).HasMaxLength(255);
            entity.Property(e => e.Term5Avg).HasMaxLength(255);
            entity.Property(e => e.Term6Avg).HasMaxLength(255);
            entity.Property(e => e.YearId)
                .HasMaxLength(255)
                .HasColumnName("YearID");
        });

        modelBuilder.Entity<Rwaddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWaddress");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Greeting1).HasMaxLength(128);
            entity.Property(e => e.Greeting2).HasMaxLength(128);
            entity.Property(e => e.Greeting3).HasMaxLength(128);
            entity.Property(e => e.Greeting4).HasMaxLength(128);
            entity.Property(e => e.Greeting5).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NewStudentInquiryId).HasColumnName("NewStudentInquiryID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip)
                .HasMaxLength(255)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Rwclass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWClasses");

            entity.Property(e => e.AidId).HasColumnName("AidID");
            entity.Property(e => e.AltStaffId).HasColumnName("AltStaffID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassLms).HasColumnName("ClassLMS");
            entity.Property(e => e.Color).HasMaxLength(7);
            entity.Property(e => e.ColorText).HasMaxLength(100);
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.DefaultAssignmentMaxPoints).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.GbkGradeMethod).HasMaxLength(50);
            entity.Property(e => e.GbkStandardCalculationDecayRate).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.GbkTimeFrame).HasMaxLength(50);
            entity.Property(e => e.GoogleCourseId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GradeLevels).HasMaxLength(50);
            entity.Property(e => e.LegacyClassId)
                .HasMaxLength(20)
                .HasColumnName("LegacyClassID");
            entity.Property(e => e.LinkedClassId).HasColumnName("LinkedClassID");
            entity.Property(e => e.MaleFemale).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Pwhomework)
                .HasMaxLength(255)
                .HasColumnName("PWHomework");
            entity.Property(e => e.PwlessonPlan)
                .HasMaxLength(255)
                .HasColumnName("PWLessonPlan");
            entity.Property(e => e.Pwteacher)
                .HasMaxLength(255)
                .HasColumnName("PWTeacher");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomOrientationMarker).HasMaxLength(50);
            entity.Property(e => e.Section).HasMaxLength(50);
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.StandardMasteryGradeMinVal0).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMasteryGradeMinVal1).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMasteryGradeMinVal2).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMaxGrade).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.Team).HasMaxLength(50);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.WebProgressReportStyle).HasMaxLength(50);
            entity.Property(e => e.YearId).HasColumnName("YearID");
        });

        modelBuilder.Entity<RwconfigSchool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWConfigSchool");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.BeginWebLunch).HasColumnType("smalldatetime");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ClockFormatId).HasColumnName("ClockFormatID");
            entity.Property(e => e.CollegeBoardSchoolCode).HasMaxLength(50);
            entity.Property(e => e.ConfigSchoolId).HasColumnName("ConfigSchoolID");
            entity.Property(e => e.DefaultTemplate).HasMaxLength(50);
            entity.Property(e => e.DefaultTermId).HasColumnName("DefaultTermID");
            entity.Property(e => e.DefaultYearId).HasColumnName("DefaultYearID");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.DonateNowContact).HasMaxLength(128);
            entity.Property(e => e.DonateNowMessage).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EndWebLunch).HasColumnType("smalldatetime");
            entity.Property(e => e.EnrollmentNotificationTemplateExistingStudent).HasColumnName("EnrollmentNotificationTemplate_ExistingStudent");
            entity.Property(e => e.EnrollmentNotificationTemplateNewStudent).HasColumnName("EnrollmentNotificationTemplate_NewStudent");
            entity.Property(e => e.EnrollmentYearId).HasColumnName("EnrollmentYearID");
            entity.Property(e => e.FamilyNameCouple1).HasMaxLength(50);
            entity.Property(e => e.FamilyNameCouple2).HasMaxLength(50);
            entity.Property(e => e.FamilyNameCouple3).HasMaxLength(50);
            entity.Property(e => e.FamilyNameIndividual1).HasMaxLength(50);
            entity.Property(e => e.FamilyNameIndividual2).HasMaxLength(50);
            entity.Property(e => e.FamilyNameIndividual3).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.GbkCurrentYearEditOnly).HasColumnName("GBK_CurrentYearEditOnly");
            entity.Property(e => e.GbkTerm1).HasColumnName("GBK_Term1");
            entity.Property(e => e.GbkTerm2).HasColumnName("GBK_Term2");
            entity.Property(e => e.GbkTerm3).HasColumnName("GBK_Term3");
            entity.Property(e => e.GbkTerm4).HasColumnName("GBK_Term4");
            entity.Property(e => e.GbkTerm5).HasColumnName("GBK_Term5");
            entity.Property(e => e.GbkTerm6).HasColumnName("GBK_Term6");
            entity.Property(e => e.LessonPlanLabel1).HasMaxLength(50);
            entity.Property(e => e.LessonPlanLabel2).HasMaxLength(50);
            entity.Property(e => e.LessonPlanLabel3).HasMaxLength(50);
            entity.Property(e => e.LessonPlanLabel4).HasMaxLength(50);
            entity.Property(e => e.LibraryPolicyAccountingCategoryId).HasColumnName("LibraryPolicyAccountingCategoryID");
            entity.Property(e => e.LibraryPolicyFiscalYearId).HasColumnName("LibraryPolicyFiscalYearID");
            entity.Property(e => e.LunchAccountingCategoryId).HasColumnName("LunchAccountingCategoryID");
            entity.Property(e => e.LunchAccountingSystemId).HasColumnName("LunchAccountingSystemID");
            entity.Property(e => e.LunchFiscalYearId).HasColumnName("LunchFiscalYearID");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NextYearId).HasColumnName("NextYearID");
            entity.Property(e => e.NotificationEmail1).HasMaxLength(256);
            entity.Property(e => e.NotificationEmail2).HasMaxLength(256);
            entity.Property(e => e.OafactsAccount)
                .HasMaxLength(50)
                .HasColumnName("OAFactsAccount");
            entity.Property(e => e.OafactsAdjustmentReason)
                .HasMaxLength(50)
                .HasColumnName("OAFactsAdjustmentReason");
            entity.Property(e => e.OafactsTerm)
                .HasMaxLength(50)
                .HasColumnName("OAFactsTerm");
            entity.Property(e => e.OeAccountingSystemId).HasColumnName("OE_AccountingSystemID");
            entity.Property(e => e.OeCategoryId).HasColumnName("OE_CategoryID");
            entity.Property(e => e.OeFiscalYearId).HasColumnName("OE_FiscalYearID");
            entity.Property(e => e.OeTuitionPlanFiscalYearId).HasColumnName("OE_Tuition_Plan_Fiscal_Year_ID");
            entity.Property(e => e.OefactsAccount)
                .HasMaxLength(50)
                .HasColumnName("OEFactsAccount");
            entity.Property(e => e.OefactsAdjustmentReason)
                .HasMaxLength(50)
                .HasColumnName("OEFactsAdjustmentReason");
            entity.Property(e => e.OefactsTerm)
                .HasMaxLength(50)
                .HasColumnName("OEFactsTerm");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Pwbanner)
                .HasMaxLength(128)
                .HasColumnName("PWBanner");
            entity.Property(e => e.PwdefaultStaffIdforComments).HasColumnName("PWDefaultStaffIDforComments");
            entity.Property(e => e.PwheaderColor1)
                .HasMaxLength(50)
                .HasColumnName("PWHeaderColor1");
            entity.Property(e => e.PwheaderColor2)
                .HasMaxLength(50)
                .HasColumnName("PWHeaderColor2");
            entity.Property(e => e.PwheaderPicturePath)
                .HasMaxLength(128)
                .HasColumnName("PWHeaderPicturePath");
            entity.Property(e => e.PwmascotName)
                .HasMaxLength(50)
                .HasColumnName("PWMascotName");
            entity.Property(e => e.PwscheduleTemplate)
                .HasMaxLength(128)
                .HasColumnName("PWScheduleTemplate");
            entity.Property(e => e.PwscheduleTermId).HasColumnName("PWScheduleTermID");
            entity.Property(e => e.PwscheduleYearId).HasColumnName("PWScheduleYearID");
            entity.Property(e => e.PwschoolName)
                .HasMaxLength(50)
                .HasColumnName("PWSchoolName");
            entity.Property(e => e.PwtermId).HasColumnName("PWTermID");
            entity.Property(e => e.PwtermId2).HasColumnName("PWTermID2");
            entity.Property(e => e.PwtextColor)
                .HasMaxLength(50)
                .HasColumnName("PWTextColor");
            entity.Property(e => e.Pwversion).HasColumnName("pwversion");
            entity.Property(e => e.PwyearId).HasColumnName("PWYearID");
            entity.Property(e => e.RcExam1).HasColumnName("RC_Exam1");
            entity.Property(e => e.RcExam2).HasColumnName("RC_Exam2");
            entity.Property(e => e.RcExam3).HasColumnName("RC_Exam3");
            entity.Property(e => e.RcFinalGrade).HasColumnName("RC_FinalGrade");
            entity.Property(e => e.RcSem1).HasColumnName("RC_Sem1");
            entity.Property(e => e.RcSem2).HasColumnName("RC_Sem2");
            entity.Property(e => e.RcSem3).HasColumnName("RC_Sem3");
            entity.Property(e => e.RcTerm1).HasColumnName("RC_Term1");
            entity.Property(e => e.RcTerm2).HasColumnName("RC_Term2");
            entity.Property(e => e.RcTerm3).HasColumnName("RC_Term3");
            entity.Property(e => e.RcTerm4).HasColumnName("RC_Term4");
            entity.Property(e => e.RcTerm5).HasColumnName("RC_Term5");
            entity.Property(e => e.RcTerm6).HasColumnName("RC_Term6");
            entity.Property(e => e.ReportCardNote1).HasMaxLength(255);
            entity.Property(e => e.ReportCardNote2).HasMaxLength(255);
            entity.Property(e => e.ReportCardNote3).HasMaxLength(255);
            entity.Property(e => e.ReportCardNote4).HasMaxLength(255);
            entity.Property(e => e.ReportCardNote5).HasMaxLength(255);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolLms).HasColumnName("SchoolLMS");
            entity.Property(e => e.SchoolName).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.TranscriptNote2).HasMaxLength(255);
            entity.Property(e => e.TranscriptNote3).HasMaxLength(255);
            entity.Property(e => e.TranscriptNote4).HasMaxLength(255);
            entity.Property(e => e.TranscriptNote5).HasMaxLength(255);
            entity.Property(e => e.TranscriptT1suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT1Suffix");
            entity.Property(e => e.TranscriptT2suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT2Suffix");
            entity.Property(e => e.TranscriptT3suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT3Suffix");
            entity.Property(e => e.TranscriptT4suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT4Suffix");
            entity.Property(e => e.TranscriptT5suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT5Suffix");
            entity.Property(e => e.TranscriptT6suffix)
                .HasMaxLength(50)
                .HasColumnName("TranscriptT6Suffix");
            entity.Property(e => e.Web).HasMaxLength(50);
            entity.Property(e => e.WebCourseRequestsFilterByGradeLevel).HasColumnName("WebCourseRequestsFilterByGradeLEvel");
            entity.Property(e => e.WebCourseRequestsYearId).HasColumnName("WebCourseRequestsYearID");
            entity.Property(e => e.Zip).HasMaxLength(50);
        });

        modelBuilder.Entity<Rwcourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWCourses");

            entity.Property(e => e.Abbreviation).HasMaxLength(50);
            entity.Property(e => e.Corequisites).HasMaxLength(50);
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseType).HasMaxLength(50);
            entity.Property(e => e.DefaultStaffId).HasColumnName("DefaultStaffID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.Equivalents).HasMaxLength(50);
            entity.Property(e => e.Hs).HasColumnName("HS");
            entity.Property(e => e.IbcourseId).HasColumnName("IBCourseID");
            entity.Property(e => e.LegacyCourseId)
                .HasMaxLength(20)
                .HasColumnName("LegacyCourseID");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.LinkedCourseId).HasColumnName("LinkedCourseID");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MoodleCourseId).HasColumnName("MoodleCourseID");
            entity.Property(e => e.PatternGroup).HasMaxLength(50);
            entity.Property(e => e.Prerequisites).HasMaxLength(50);
            entity.Property(e => e.Rcplacement).HasColumnName("RCPlacement");
            entity.Property(e => e.ReqGrade).HasMaxLength(50);
            entity.Property(e => e.RequiredRoomId).HasColumnName("RequiredRoomID");
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateId)
                .HasMaxLength(64)
                .HasColumnName("StateID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<RwcourseLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWCourseLevel");

            entity.Property(e => e.CourseLevelId).HasColumnName("CourseLevelID");
            entity.Property(e => e.DefaultAssignmentMaxPoints).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FE1).HasColumnName("f_e1");
            entity.Property(e => e.FE2).HasColumnName("f_e2");
            entity.Property(e => e.FE3).HasColumnName("f_e3");
            entity.Property(e => e.FS1).HasColumnName("f_s1");
            entity.Property(e => e.FS2).HasColumnName("f_s2");
            entity.Property(e => e.FS3).HasColumnName("f_s3");
            entity.Property(e => e.FT1).HasColumnName("f_t1");
            entity.Property(e => e.FT2).HasColumnName("f_t2");
            entity.Property(e => e.FT3).HasColumnName("f_t3");
            entity.Property(e => e.FT4).HasColumnName("f_t4");
            entity.Property(e => e.FT5).HasColumnName("f_t5");
            entity.Property(e => e.FT6).HasColumnName("f_t6");
            entity.Property(e => e.GbkGradeMethod).HasMaxLength(50);
            entity.Property(e => e.GbkStandardCalculationDecayRate).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.GbkTimeFrame).HasMaxLength(50);
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.S1E1).HasColumnName("s1_e1");
            entity.Property(e => e.S1E2).HasColumnName("s1_e2");
            entity.Property(e => e.S1E3).HasColumnName("s1_e3");
            entity.Property(e => e.S1T1).HasColumnName("s1_t1");
            entity.Property(e => e.S1T2).HasColumnName("s1_t2");
            entity.Property(e => e.S1T3).HasColumnName("s1_t3");
            entity.Property(e => e.S1T4).HasColumnName("s1_t4");
            entity.Property(e => e.S1T5).HasColumnName("s1_t5");
            entity.Property(e => e.S1T6).HasColumnName("s1_t6");
            entity.Property(e => e.S2E1).HasColumnName("s2_e1");
            entity.Property(e => e.S2E2).HasColumnName("s2_e2");
            entity.Property(e => e.S2E3).HasColumnName("s2_e3");
            entity.Property(e => e.S2T1).HasColumnName("s2_t1");
            entity.Property(e => e.S2T2).HasColumnName("s2_t2");
            entity.Property(e => e.S2T3).HasColumnName("s2_t3");
            entity.Property(e => e.S2T4).HasColumnName("s2_t4");
            entity.Property(e => e.S2T5).HasColumnName("s2_t5");
            entity.Property(e => e.S2T6).HasColumnName("s2_t6");
            entity.Property(e => e.S3E1).HasColumnName("s3_e1");
            entity.Property(e => e.S3E2).HasColumnName("s3_e2");
            entity.Property(e => e.S3E3).HasColumnName("s3_e3");
            entity.Property(e => e.S3T1).HasColumnName("s3_t1");
            entity.Property(e => e.S3T2).HasColumnName("s3_t2");
            entity.Property(e => e.S3T3).HasColumnName("s3_t3");
            entity.Property(e => e.S3T4).HasColumnName("s3_t4");
            entity.Property(e => e.S3T5).HasColumnName("s3_t5");
            entity.Property(e => e.S3T6).HasColumnName("s3_t6");
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardMasteryGradeMinVal0).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMasteryGradeMinVal1).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMasteryGradeMinVal2).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.StandardMaxGrade).HasColumnType("numeric(9, 4)");
            entity.Property(e => e.WebProgressReportStyle).HasMaxLength(50);
        });

        modelBuilder.Entity<RwcourseLevelLetterGrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWCourseLevelLetterGrades");

            entity.Property(e => e.CourseLevelId).HasColumnName("CourseLevelID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Gpa)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("GPA");
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.Passing).HasColumnName("passing");
            entity.Property(e => e.Schoolcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("schoolcode");
            entity.Property(e => e.Ugpa)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("UGPA");
        });

        modelBuilder.Entity<RwcourseLevelNumberGrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWCourseLevelNumberGrades");

            entity.Property(e => e.Average).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.CourseLevelId).HasColumnName("CourseLevelID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Gpa)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("GPA");
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.Passing).HasColumnName("passing");
            entity.Property(e => e.Schoolcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("schoolcode");
            entity.Property(e => e.Ugpa)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("UGPA");
        });

        modelBuilder.Entity<Rwdefinedlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWdefinedlists");

            entity.Property(e => e.Dlid).HasColumnName("DLID");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasMaxLength(64);
        });

        modelBuilder.Entity<RwfamilyConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWFamilyConfig");

            entity.Property(e => e.AccountingCode).HasMaxLength(256);
            entity.Property(e => e.FamilyCode).HasMaxLength(128);
            entity.Property(e => e.FamilyEmail).HasMaxLength(256);
            entity.Property(e => e.FamilyId).HasColumnName("FamilyID");
            entity.Property(e => e.FamilyLetter).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyName2).HasMaxLength(128);
            entity.Property(e => e.FamilyNameBp)
                .HasMaxLength(50)
                .HasColumnName("FamilyNameBP");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RwgradeLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWGradeLevels");

            entity.Property(e => e.AdmissionTrackingId).HasColumnName("AdmissionTrackingID");
            entity.Property(e => e.AttendanceMethod).HasMaxLength(50);
            entity.Property(e => e.CurriculumPlanId).HasColumnName("CurriculumPlanID");
            entity.Property(e => e.Description).HasMaxLength(128);
            entity.Property(e => e.GradDate).HasMaxLength(50);
            entity.Property(e => e.GradeLevel).HasMaxLength(50);
            entity.Property(e => e.GradeLevelDescriptorId).HasColumnName("GradeLevelDescriptorID");
            entity.Property(e => e.GradeLevelId).HasColumnName("GradeLevelID");
            entity.Property(e => e.InquiryTrackingId).HasColumnName("InquiryTrackingID");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NextGradeLevel).HasMaxLength(50);
            entity.Property(e => e.NextSchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatronGroupId).HasColumnName("PatronGroupID");
            entity.Property(e => e.ProgressReportTemplate).HasMaxLength(128);
            entity.Property(e => e.ReenrollTrackingId).HasColumnName("ReenrollTrackingID");
            entity.Property(e => e.ReportCardTemplate).HasMaxLength(128);
            entity.Property(e => e.ScheduleTemplate).HasMaxLength(50);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TranscriptTemplate).HasMaxLength(128);
        });

        modelBuilder.Entity<RwparentStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWParent_student");

            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Pwblock).HasColumnName("PWBlock");
            entity.Property(e => e.Reenroll).HasColumnName("reenroll");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<Rwperson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWPerson");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.AutoEmailProgressReport)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.AutoLicense).HasMaxLength(50);
            entity.Property(e => e.AutoMake).HasMaxLength(50);
            entity.Property(e => e.AutoModel).HasMaxLength(50);
            entity.Property(e => e.BachelorDegree).HasMaxLength(128);
            entity.Property(e => e.BachelorDegree2).HasMaxLength(128);
            entity.Property(e => e.BachelorSchool).HasMaxLength(128);
            entity.Property(e => e.BachelorSchool2).HasMaxLength(128);
            entity.Property(e => e.BachelorYear).HasMaxLength(50);
            entity.Property(e => e.BachelorYear2).HasMaxLength(50);
            entity.Property(e => e.BaptismChurch).HasMaxLength(50);
            entity.Property(e => e.BaptismCity).HasMaxLength(50);
            entity.Property(e => e.BaptismDate).HasMaxLength(50);
            entity.Property(e => e.BaptismState).HasMaxLength(50);
            entity.Property(e => e.BarMitzvahChurch).HasMaxLength(50);
            entity.Property(e => e.BarMitzvahCity).HasMaxLength(50);
            entity.Property(e => e.BarMitzvahDate).HasMaxLength(50);
            entity.Property(e => e.BarMitzvahState).HasMaxLength(50);
            entity.Property(e => e.BirthCity).HasMaxLength(64);
            entity.Property(e => e.BirthCountry).HasMaxLength(64);
            entity.Property(e => e.BirthCounty)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.BirthState).HasMaxLength(64);
            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.Birthplace).HasMaxLength(50);
            entity.Property(e => e.BloodType).HasMaxLength(50);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.ChatLogin).HasMaxLength(50);
            entity.Property(e => e.ChurchId).HasColumnName("ChurchID");
            entity.Property(e => e.Citizenship).HasMaxLength(50);
            entity.Property(e => e.CommunionChurch).HasMaxLength(50);
            entity.Property(e => e.CommunionCity).HasMaxLength(50);
            entity.Property(e => e.CommunionDate).HasMaxLength(50);
            entity.Property(e => e.CommunionState).HasMaxLength(50);
            entity.Property(e => e.Company).HasMaxLength(255);
            entity.Property(e => e.ConfirmationChurch).HasMaxLength(50);
            entity.Property(e => e.ConfirmationCity).HasMaxLength(50);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(50);
            entity.Property(e => e.ConfirmationState).HasMaxLength(50);
            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.CryptPayOeguid)
                .HasMaxLength(128)
                .HasColumnName("CryptPayOEGUID");
            entity.Property(e => e.CryptPayPnguid)
                .HasMaxLength(128)
                .HasColumnName("CryptPayPNGUID");
            entity.Property(e => e.DayCareRateId).HasColumnName("DayCareRateID");
            entity.Property(e => e.DefaultLanguage).HasMaxLength(50);
            entity.Property(e => e.Denomination).HasMaxLength(50);
            entity.Property(e => e.Dentist).HasMaxLength(128);
            entity.Property(e => e.DentistAddress).HasMaxLength(128);
            entity.Property(e => e.DentistPhone).HasMaxLength(128);
            entity.Property(e => e.DirectoryBlockAddress).HasColumnName("Directory_BlockAddress");
            entity.Property(e => e.DirectoryBlockCellPhone).HasColumnName("Directory_BlockCellPhone");
            entity.Property(e => e.DirectoryBlockEmail).HasColumnName("Directory_BlockEmail");
            entity.Property(e => e.DirectoryBlockHomePhone).HasColumnName("Directory_BlockHomePhone");
            entity.Property(e => e.DirectoryBlockName).HasColumnName("Directory_BlockName");
            entity.Property(e => e.Doctor).HasMaxLength(128);
            entity.Property(e => e.DoctorAddress).HasMaxLength(128);
            entity.Property(e => e.DoctorPhone).HasMaxLength(128);
            entity.Property(e => e.DonorCompanyId).HasColumnName("DonorCompanyID");
            entity.Property(e => e.DriversLicense).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Email2).HasMaxLength(256);
            entity.Property(e => e.EnrollmentResponsibilityId).HasColumnName("EnrollmentResponsibilityID");
            entity.Property(e => e.Ethnicity).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(64);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Highschool).HasMaxLength(128);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.Hospital).HasMaxLength(128);
            entity.Property(e => e.HospitalAddress).HasMaxLength(128);
            entity.Property(e => e.ImportId)
                .HasMaxLength(20)
                .HasColumnName("ImportID");
            entity.Property(e => e.InsuranceCompany).HasMaxLength(128);
            entity.Property(e => e.InsuranceGroup).HasMaxLength(128);
            entity.Property(e => e.InsurancePolicy).HasMaxLength(128);
            entity.Property(e => e.JobCategory).HasMaxLength(64);
            entity.Property(e => e.LastConfigSchoolId).HasColumnName("LastConfigSchoolID");
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.LastSchoolLogin).HasMaxLength(50);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(50)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MaidenName).HasMaxLength(128);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MasterDegree).HasMaxLength(128);
            entity.Property(e => e.MasterDegree2).HasMaxLength(128);
            entity.Property(e => e.MasterSchool).HasMaxLength(128);
            entity.Property(e => e.MasterSchool2).HasMaxLength(128);
            entity.Property(e => e.MasterYear).HasMaxLength(50);
            entity.Property(e => e.MasterYear2).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(64);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NewStudentInquiryId).HasColumnName("NewStudentInquiryID");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(2000);
            entity.Property(e => e.Occupation).HasMaxLength(128);
            entity.Property(e => e.ParentAlertPreference).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("_ParentID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PasswordCreationDate).HasColumnType("datetime");
            entity.Property(e => e.PasswordResetUrlSendDate).HasColumnType("datetime");
            entity.Property(e => e.PathToPicture).HasMaxLength(255);
            entity.Property(e => e.PermitNumber).HasMaxLength(50);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Phddegree)
                .HasMaxLength(50)
                .HasColumnName("PHDDegree");
            entity.Property(e => e.Phddegree2)
                .HasMaxLength(50)
                .HasColumnName("PHDDegree2");
            entity.Property(e => e.Phdschool)
                .HasMaxLength(128)
                .HasColumnName("PHDSchool");
            entity.Property(e => e.Phdschool2)
                .HasMaxLength(128)
                .HasColumnName("PHDSchool2");
            entity.Property(e => e.Phdyear)
                .HasMaxLength(50)
                .HasColumnName("PHDYear");
            entity.Property(e => e.Phdyear2)
                .HasMaxLength(50)
                .HasColumnName("PHDYear2");
            entity.Property(e => e.PrimaryLanguage).HasMaxLength(50);
            entity.Property(e => e.Pswd)
                .HasMaxLength(8000)
                .HasColumnName("pswd");
            entity.Property(e => e.PublicSchoolCode).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolCounty).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolDistrict).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolLocalSchool).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolState).HasMaxLength(50);
            entity.Property(e => e.ReconciliationChurch).HasMaxLength(50);
            entity.Property(e => e.ReconciliationCity).HasMaxLength(50);
            entity.Property(e => e.ReconciliationDate).HasMaxLength(50);
            entity.Property(e => e.ReconciliationState).HasMaxLength(50);
            entity.Property(e => e.ResetPasswordDate).HasColumnType("datetime");
            entity.Property(e => e.Salutation).HasMaxLength(64);
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.StaffId).HasColumnName("_StaffID");
            entity.Property(e => e.StudentId).HasColumnName("_StudentID");
            entity.Property(e => e.Subdivision).HasMaxLength(64);
            entity.Property(e => e.Suffix).HasMaxLength(50);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.WorkCity).HasMaxLength(50);
            entity.Property(e => e.WorkCityStateZip).HasMaxLength(255);
            entity.Property(e => e.WorkCountry).HasMaxLength(255);
            entity.Property(e => e.WorkPhone).HasMaxLength(128);
            entity.Property(e => e.WorkPhoneExtension).HasMaxLength(50);
            entity.Property(e => e.WorkState).HasMaxLength(50);
            entity.Property(e => e.WorkStreet).HasMaxLength(255);
            entity.Property(e => e.WorkZip).HasMaxLength(50);
        });

        modelBuilder.Entity<RwpersonFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWPerson_Family");

            entity.Property(e => e.FamilyId).HasColumnName("FamilyID");
            entity.Property(e => e.FinancialResponsibilityPercent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
        });

        modelBuilder.Entity<RwschedulePattern>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWSchedulePatterns");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PatternGroup).HasMaxLength(50);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
        });

        modelBuilder.Entity<RwscheduleTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWScheduleTemplate");

            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateName).HasMaxLength(50);
            entity.Property(e => e.YearId).HasColumnName("YearID");
        });

        modelBuilder.Entity<RwschoolTerm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWSchoolTerm");

            entity.Property(e => e.FirstDay).HasColumnType("datetime");
            entity.Property(e => e.LastDay).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolTermId).HasColumnName("SchoolTermID");
            entity.Property(e => e.SemesterId).HasColumnName("SemesterID");
            entity.Property(e => e.TermId).HasColumnName("TermID");
            entity.Property(e => e.YearId).HasColumnName("YearID");
        });

        modelBuilder.Entity<RwschoolYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWSchoolYear");

            entity.Property(e => e.FactstermCode)
                .HasMaxLength(50)
                .HasColumnName("FACTSTermCode");
            entity.Property(e => e.FirstDay).HasColumnType("datetime");
            entity.Property(e => e.LastDay).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.OarequestInfoEnabled).HasColumnName("OARequestInfoEnabled");
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.SchoolYear).HasMaxLength(50);
            entity.Property(e => e.YearId).HasColumnName("YearID");
        });

        modelBuilder.Entity<Rwstaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWstaff");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.BachelorDegree).HasMaxLength(128);
            entity.Property(e => e.BachelorDegree2).HasMaxLength(128);
            entity.Property(e => e.BachelorSchool).HasMaxLength(128);
            entity.Property(e => e.BachelorSchool2).HasMaxLength(128);
            entity.Property(e => e.BachelorYear).HasMaxLength(50);
            entity.Property(e => e.BachelorYear2).HasMaxLength(50);
            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.ChurchId).HasColumnName("ChurchID");
            entity.Property(e => e.Citizenship).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Denomination).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(64);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Email2).HasMaxLength(256);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ethnicity).HasMaxLength(50);
            entity.Property(e => e.FinancialFamilyId).HasColumnName("FinancialFamilyID");
            entity.Property(e => e.FirstName).HasMaxLength(64);
            entity.Property(e => e.Fte).HasColumnName("FTE");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Highschool).HasMaxLength(128);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.Hs).HasColumnName("HS");
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.Legacypersonid)
                .HasMaxLength(50)
                .HasColumnName("legacypersonid");
            entity.Property(e => e.MasterDegree).HasMaxLength(128);
            entity.Property(e => e.MasterDegree2).HasMaxLength(128);
            entity.Property(e => e.MasterSchool).HasMaxLength(128);
            entity.Property(e => e.MasterSchool2).HasMaxLength(128);
            entity.Property(e => e.MasterYear).HasMaxLength(50);
            entity.Property(e => e.MasterYear2).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(64);
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(2000);
            entity.Property(e => e.Occupation).HasMaxLength(128);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PathToPicture).HasMaxLength(255);
            entity.Property(e => e.Pda).HasColumnName("PDA");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Phddegree)
                .HasMaxLength(50)
                .HasColumnName("PHDDegree");
            entity.Property(e => e.Phddegree2)
                .HasMaxLength(50)
                .HasColumnName("PHDDegree2");
            entity.Property(e => e.Phdschool)
                .HasMaxLength(128)
                .HasColumnName("PHDSchool");
            entity.Property(e => e.Phdschool2)
                .HasMaxLength(128)
                .HasColumnName("PHDSchool2");
            entity.Property(e => e.Phdyear)
                .HasMaxLength(50)
                .HasColumnName("PHDYear");
            entity.Property(e => e.Phdyear2)
                .HasMaxLength(50)
                .HasColumnName("PHDYear2");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.Salutation).HasMaxLength(64);
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Suffix).HasMaxLength(50);
            entity.Property(e => e.WorkPhone).HasMaxLength(128);
            entity.Property(e => e.WorkPhoneExtension).HasMaxLength(50);
            entity.Property(e => e.Zip)
                .HasMaxLength(255)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Rwstudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWstudents");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.AdvisorId).HasColumnName("AdvisorID");
            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.ChurchId).HasColumnName("ChurchID");
            entity.Property(e => e.Citizenship).HasMaxLength(50);
            entity.Property(e => e.ClassOf).HasMaxLength(50);
            entity.Property(e => e.Combination1).HasMaxLength(50);
            entity.Property(e => e.Combination2).HasMaxLength(50);
            entity.Property(e => e.Denomination).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EnrollDate).HasColumnType("datetime");
            entity.Property(e => e.Ethnicity).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(64);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GradeLevel).HasMaxLength(50);
            entity.Property(e => e.GraduationDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(50)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Locker1).HasMaxLength(50);
            entity.Property(e => e.Locker2).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(64);
            entity.Property(e => e.NextGradeLevel).HasMaxLength(50);
            entity.Property(e => e.NextSchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NextStatus).HasMaxLength(50);
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(2000);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PathToPicture).HasMaxLength(255);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Placement).HasMaxLength(50);
            entity.Property(e => e.PrimaryLanguage).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolCode).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolCounty).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolDistrict).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolLocalSchool).HasMaxLength(50);
            entity.Property(e => e.PublicSchoolState).HasMaxLength(50);
            entity.Property(e => e.ReEnrollMessage).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(64);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(50)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentMentorId).HasColumnName("StudentMentorID");
            entity.Property(e => e.Substatus).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(50);
            entity.Property(e => e.TranscriptNote1).HasMaxLength(4000);
            entity.Property(e => e.WithdrawDate).HasColumnType("datetime");
            entity.Property(e => e.WithdrawReason).HasMaxLength(50);
        });

        modelBuilder.Entity<RwstudentRank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWStudentRank");

            entity.Property(e => e.GradeLevel).HasMaxLength(50);
            entity.Property(e => e.HonorId).HasColumnName("HonorID");
            entity.Property(e => e.HonorRollId).HasColumnName("HonorRollID");
            entity.Property(e => e.RankDate).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TermGpa).HasColumnName("TermGPA");
            entity.Property(e => e.TermHighGpa).HasColumnName("TermHighGPA");
            entity.Property(e => e.TermHighUgpa).HasColumnName("TermHighUGPA");
            entity.Property(e => e.TermId).HasColumnName("TermID");
            entity.Property(e => e.TermLowGpa).HasColumnName("TermLowGPA");
            entity.Property(e => e.TermLowUgpa).HasColumnName("TermLowUGPA");
            entity.Property(e => e.TermUgpa).HasColumnName("TermUGPA");
            entity.Property(e => e.Udhonor1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UDHonor1");
            entity.Property(e => e.Udhonor2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UDHonor2");
            entity.Property(e => e.Udhonor3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UDHonor3");
            entity.Property(e => e.Udhonor4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UDHonor4");
            entity.Property(e => e.Udhonor5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UDHonor5");
            entity.Property(e => e.YearId).HasColumnName("YearID");
        });

        modelBuilder.Entity<Rwudfield>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWUDField");

            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.FieldName).HasMaxLength(128);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<RwudfieldDefinedList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWUDFieldDefinedList");

            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        modelBuilder.Entity<Rwudgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RWUDGroup");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(128);
            entity.Property(e => e.GroupType).HasMaxLength(50);
            entity.Property(e => e.SchoolCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkillSetBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__SkillSet__360414FF5FBBACAE");

            entity.ToTable("SkillSetBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SingleGrade).HasMaxLength(255);
            entity.Property(e => e.Skill).HasMaxLength(255);
            entity.Property(e => e.SkillOrder).HasMaxLength(255);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.SubjectOrder).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__StaffBP__360414FF983A2EC2");

            entity.ToTable("StaffBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Active).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BachelorDegree).HasMaxLength(255);
            entity.Property(e => e.BachelorDegree2).HasMaxLength(255);
            entity.Property(e => e.BachelorSchool).HasMaxLength(255);
            entity.Property(e => e.BachelorSchool2).HasMaxLength(255);
            entity.Property(e => e.BachelorYear).HasMaxLength(255);
            entity.Property(e => e.BachelorYear2).HasMaxLength(255);
            entity.Property(e => e.BirthCity).HasMaxLength(255);
            entity.Property(e => e.BirthCountry).HasMaxLength(255);
            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.BirthState).HasMaxLength(255);
            entity.Property(e => e.BloodType).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Church).HasMaxLength(255);
            entity.Property(e => e.Citizenship).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.DentistAddress).HasMaxLength(255);
            entity.Property(e => e.DentistName).HasMaxLength(255);
            entity.Property(e => e.DentistPhone).HasMaxLength(255);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Districtuser).HasMaxLength(255);
            entity.Property(e => e.DoctorAddress).HasMaxLength(255);
            entity.Property(e => e.DoctorHospital).HasMaxLength(255);
            entity.Property(e => e.DoctorName).HasMaxLength(255);
            entity.Property(e => e.DoctorPhone).HasMaxLength(255);
            entity.Property(e => e.Elem)
                .HasMaxLength(255)
                .HasColumnName("ELEM");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasMaxLength(255);
            entity.Property(e => e.Ethnicity).HasMaxLength(255);
            entity.Property(e => e.ExperienceSchool).HasMaxLength(255);
            entity.Property(e => e.Experiencetotal).HasMaxLength(255);
            entity.Property(e => e.Faculty).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.FullTime).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.HighSchool).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.Hs)
                .HasMaxLength(255)
                .HasColumnName("HS");
            entity.Property(e => e.InsuranceCompany).HasMaxLength(255);
            entity.Property(e => e.InsuranceGroup).HasMaxLength(255);
            entity.Property(e => e.InsurancePolicy).HasMaxLength(255);
            entity.Property(e => e.Jobcategory).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MaritalStatus).HasMaxLength(255);
            entity.Property(e => e.MasterDegree).HasMaxLength(255);
            entity.Property(e => e.MasterDegree2).HasMaxLength(255);
            entity.Property(e => e.MasterSchool).HasMaxLength(255);
            entity.Property(e => e.MasterSchool2).HasMaxLength(255);
            entity.Property(e => e.MasterYear).HasMaxLength(255);
            entity.Property(e => e.MasterYear2).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Ms)
                .HasMaxLength(255)
                .HasColumnName("MS");
            entity.Property(e => e.NickName).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Occupation).HasMaxLength(255);
            entity.Property(e => e.PermissiontoTreat).HasMaxLength(255);
            entity.Property(e => e.Phddegree)
                .HasMaxLength(255)
                .HasColumnName("PHDDegree");
            entity.Property(e => e.Phddegree2)
                .HasMaxLength(255)
                .HasColumnName("PHDDegree2");
            entity.Property(e => e.Phdschool)
                .HasMaxLength(255)
                .HasColumnName("PHDSchool");
            entity.Property(e => e.Phdschool2)
                .HasMaxLength(255)
                .HasColumnName("PHDSchool2");
            entity.Property(e => e.Phdyear)
                .HasMaxLength(255)
                .HasColumnName("PHDYear");
            entity.Property(e => e.Phdyear2)
                .HasMaxLength(255)
                .HasColumnName("PHDYear2");
            entity.Property(e => e.Primarylanguage).HasMaxLength(255);
            entity.Property(e => e.Ps)
                .HasMaxLength(255)
                .HasColumnName("PS");
            entity.Property(e => e.Room).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.Ssn)
                .HasMaxLength(255)
                .HasColumnName("SSN");
            entity.Property(e => e.Staff).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Substitute).HasMaxLength(255);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.WorkPhone).HasMaxLength(255);
            entity.Property(e => e.WorkPhoneExtension).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffDenominationNotDefined>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffDenominationNotDefined", "val");

            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.PersonCategory)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StaffDuplicateId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffDuplicateIds", "val");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffEmailandEmail2Match>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffEmailandEmail2Match", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffEncodingIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffEncodingIssues", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffGenderNotInStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffGenderNotInStandard", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffInvalidActiveStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidActiveStatus", "val");

            entity.Property(e => e.Active).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffInvalidDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidDates", "val");

            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.StartDate).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffInvalidElem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidElem", "val");

            entity.Property(e => e.Elem)
                .HasMaxLength(255)
                .HasColumnName("ELEM");
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidExperienceSchool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidExperienceSchool", "val");

            entity.Property(e => e.ExperienceSchool).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidExperienceTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidExperienceTotal", "val");

            entity.Property(e => e.Experiencetotal).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidFaculty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidFaculty", "val");

            entity.Property(e => e.Faculty).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidFullTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidFullTime", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.FullTime).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidHS", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Hs)
                .HasMaxLength(255)
                .HasColumnName("HS");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidMS", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Ms)
                .HasMaxLength(255)
                .HasColumnName("MS");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidPS", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Ps)
                .HasMaxLength(255)
                .HasColumnName("PS");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffInvalidStaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffInvalidStaff", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Staff).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffMissingFirstorLastName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffMissingFirstorLastName", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffMissingOccupation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffMissingOccupation", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Occupation).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffNoFacultyStaffFlag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoFacultyStaffFlag", "val");

            entity.Property(e => e.Faculty).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.Staff).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffNoFamilyName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoFamilyName", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffNoFirstName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoFirstName", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffNoGradeLevelsAssigned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoGradeLevelsAssigned", "val");

            entity.Property(e => e.Elem)
                .HasMaxLength(255)
                .HasColumnName("ELEM");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Hs)
                .HasMaxLength(255)
                .HasColumnName("HS");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Ms)
                .HasMaxLength(255)
                .HasColumnName("MS");
            entity.Property(e => e.Ps)
                .HasMaxLength(255)
                .HasColumnName("PS");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffNoLastName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoLastName", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffNoLegacyPersonId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffNoLegacyPersonID", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffOccupationNotInDefaultList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffOccupationNotInDefaultList", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Occupation).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StaffPotentialParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffPotentialParent", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.YesNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Yes/No");
        });

        modelBuilder.Entity<StaffRaceNotInStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffRaceNotInStandard", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Race).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StaffStateAbbrvNotValid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StaffStateAbbrvNotValid", "val");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffcertsBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Staffcer__360414FF1EBC11C6");

            entity.ToTable("StaffcertsBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.CertLevel).HasMaxLength(255);
            entity.Property(e => e.Certification)
                .HasMaxLength(255)
                .HasColumnName("CERTIFICATION");
            entity.Property(e => e.Certificationlevel).HasMaxLength(255);
            entity.Property(e => e.Ceu)
                .HasMaxLength(255)
                .HasColumnName("CEU");
            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Expiration)
                .HasMaxLength(255)
                .HasColumnName("EXPIRATION");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Hours)
                .HasMaxLength(255)
                .HasColumnName("HOURS");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.LegacyPersonid).HasMaxLength(255);
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("NOTES");
            entity.Property(e => e.Staffid).HasMaxLength(255);
        });

        modelBuilder.Entity<StaffecBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__StaffecB__360414FFD0E515C4");

            entity.ToTable("StaffecBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Relationship).HasMaxLength(255);
            entity.Property(e => e.StaffFirstName).HasMaxLength(255);
            entity.Property(e => e.StaffLastName).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.WorkPhone).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StandAloneAlert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StandAloneAlert", "val");

            entity.Property(e => e.PersonType).HasMaxLength(10);
            entity.Property(e => e.Total).HasMaxLength(7);
        });

        modelBuilder.Entity<StateIdlegacyPersonIdnotFound>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StateIDLegacyPersonIDNotFound", "val");

            entity.Property(e => e.IdentifierTypeId)
                .HasMaxLength(255)
                .HasColumnName("IdentifierTypeID");
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.StateIdentifier).HasMaxLength(255);
        });

        modelBuilder.Entity<StateidBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__StateidB__360414FF3D164F9F");

            entity.ToTable("StateidBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.IdentifierTypeId)
                .HasMaxLength(255)
                .HasColumnName("IdentifierTypeID");
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.StateIdentifier).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentAdrNotMatchCustodian>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentAdrNotMatchCustodian", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__StudentB__360414FF4E29711C");

            entity.ToTable("StudentBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.AutoLicense).HasMaxLength(255);
            entity.Property(e => e.BaptismChurch).HasMaxLength(255);
            entity.Property(e => e.BaptismCity).HasMaxLength(255);
            entity.Property(e => e.BaptismDate).HasMaxLength(255);
            entity.Property(e => e.BaptismState).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahChurch).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahCity).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahDate).HasMaxLength(255);
            entity.Property(e => e.BarmitzvahState).HasMaxLength(255);
            entity.Property(e => e.BirthCity).HasMaxLength(255);
            entity.Property(e => e.BirthCountry).HasMaxLength(255);
            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.BirthState).HasMaxLength(255);
            entity.Property(e => e.BloodType).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.Church).HasMaxLength(255);
            entity.Property(e => e.Citizenship).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.ClassOf).HasMaxLength(255);
            entity.Property(e => e.Combination1).HasMaxLength(255);
            entity.Property(e => e.Combination2).HasMaxLength(255);
            entity.Property(e => e.CommunionChurch).HasMaxLength(255);
            entity.Property(e => e.CommunionCity).HasMaxLength(255);
            entity.Property(e => e.CommunionDate).HasMaxLength(255);
            entity.Property(e => e.CommunionState).HasMaxLength(255);
            entity.Property(e => e.ConfirmationChurch).HasMaxLength(255);
            entity.Property(e => e.ConfirmationCity).HasMaxLength(255);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(255);
            entity.Property(e => e.ConfirmationState).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Denomination).HasMaxLength(255);
            entity.Property(e => e.Dentist).HasMaxLength(255);
            entity.Property(e => e.DentistAddress).HasMaxLength(255);
            entity.Property(e => e.DentistPhone).HasMaxLength(255);
            entity.Property(e => e.Doctor).HasMaxLength(255);
            entity.Property(e => e.DrAddress).HasMaxLength(255);
            entity.Property(e => e.DrPhone).HasMaxLength(255);
            entity.Property(e => e.DriverLicense).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.EnrollDate).HasMaxLength(255);
            entity.Property(e => e.Ethnicity).HasMaxLength(255);
            entity.Property(e => e.FaepersonId)
                .HasMaxLength(255)
                .HasColumnName("FAEPersonID");
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FamilyNameSecond).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.GraduationDate).HasMaxLength(255);
            entity.Property(e => e.HomePhone).HasMaxLength(255);
            entity.Property(e => e.Hospital).HasMaxLength(255);
            entity.Property(e => e.HospitalAddress).HasMaxLength(255);
            entity.Property(e => e.InsuranceCompany).HasMaxLength(255);
            entity.Property(e => e.InsuranceGroup).HasMaxLength(255);
            entity.Property(e => e.InsurancePolicy).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Locker1).HasMaxLength(255);
            entity.Property(e => e.Locker2).HasMaxLength(255);
            entity.Property(e => e.Make).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Model).HasMaxLength(255);
            entity.Property(e => e.NickName).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PermissionToTreat).HasMaxLength(255);
            entity.Property(e => e.PermitNumber).HasMaxLength(255);
            entity.Property(e => e.PreviousSchool).HasMaxLength(255);
            entity.Property(e => e.PreviousSchoolAddress).HasMaxLength(255);
            entity.Property(e => e.PreviousSchoolEndDate).HasMaxLength(255);
            entity.Property(e => e.PreviousSchoolFromDate).HasMaxLength(255);
            entity.Property(e => e.PreviousSchoolGradeCompleted).HasMaxLength(255);
            entity.Property(e => e.PreviousSchoolNote).HasMaxLength(255);
            entity.Property(e => e.Primarylanguage).HasMaxLength(255);
            entity.Property(e => e.PublicSchoolCounty).HasMaxLength(255);
            entity.Property(e => e.PublicSchoolDistrict).HasMaxLength(255);
            entity.Property(e => e.Publicschoollocalschool).HasMaxLength(255);
            entity.Property(e => e.Publicschoolstate).HasMaxLength(255);
            entity.Property(e => e.ReconciliationChurch).HasMaxLength(255);
            entity.Property(e => e.ReconciliationCity).HasMaxLength(255);
            entity.Property(e => e.ReconciliationDate).HasMaxLength(255);
            entity.Property(e => e.ReconciliationState).HasMaxLength(255);
            entity.Property(e => e.Reducedlunch).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Ssn)
                .HasMaxLength(255)
                .HasColumnName("SSN");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.SubStatus).HasMaxLength(255);
            entity.Property(e => e.Suffix).HasMaxLength(255);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.WithdrawDate).HasMaxLength(255);
            entity.Property(e => e.WithdrawReason).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentCellPhoneinParentDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentCellPhoneinParentData", "val");

            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentDuplicateLegacyId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentDuplicateLegacyID", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.CellPhone).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentDuplicateSchoolid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentDuplicateSchoolid", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentEmail1andEmail2Match>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentEmail1andEmail2Match", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentEmailinParentDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentEmailinParentData", "val");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentEthnicityNotStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentEthnicityNotStandard", "val");

            entity.Property(e => e.Ethnicity).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentGenderNotInStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentGenderNotInStandard", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentIllogicalSacramentDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentIllogicalSacramentDates", "val");

            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.Date).HasMaxLength(255);
            entity.Property(e => e.DateType)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId).HasColumnName("RecID");
        });

        modelBuilder.Entity<StudentInParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentInParents", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StudentInvalidGradeLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentInvalidGradeLevel", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentInvalidStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentInvalidStatus", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<StudentMissingBirthdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentMissingBirthdate", "val");

            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StudentMissingEnrollDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentMissingEnrollDates", "val");

            entity.Property(e => e.EnrollDate).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentMissingFirstorLastName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentMissingFirstorLastName", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentMissingGender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentMissingGender", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StudentNoFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentNoFamily", "val");

            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
        });

        modelBuilder.Entity<StudentNoGradeLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentNoGradeLevel", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<StudentReducedLunchNotFormatted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentReducedLunchNotFormatted", "val");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.Reducedlunch).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentStateAbbrvNotValid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StudentStateAbbrvNotValid", "val");

            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.Address2).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentTransportationBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__StudentT__360414FF6D5AAB87");

            entity.ToTable("StudentTransportationBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.BusRoute).HasMaxLength(255);
            entity.Property(e => e.Friday).HasMaxLength(255);
            entity.Property(e => e.Monday).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.RouteType).HasMaxLength(255);
            entity.Property(e => e.Saturday).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
            entity.Property(e => e.Sunday).HasMaxLength(255);
            entity.Property(e => e.Thursday).HasMaxLength(255);
            entity.Property(e => e.Tuesday).HasMaxLength(255);
            entity.Property(e => e.Wednesday).HasMaxLength(255);
        });

        modelBuilder.Entity<TranscriptsBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__Transcri__360414FF2DE38699");

            entity.ToTable("TranscriptsBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Abbreviation).HasMaxLength(255);
            entity.Property(e => e.Absent).HasMaxLength(255);
            entity.Property(e => e.Calc).HasMaxLength(255);
            entity.Property(e => e.Course).HasMaxLength(255);
            entity.Property(e => e.CourseLevel).HasMaxLength(255);
            entity.Property(e => e.Credits).HasMaxLength(255);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Exam1Grade).HasMaxLength(255);
            entity.Property(e => e.Exam2Grade).HasMaxLength(255);
            entity.Property(e => e.FinalGrade).HasMaxLength(255);
            entity.Property(e => e.FinalGradeAvg).HasMaxLength(255);
            entity.Property(e => e.FinalGradeGpa)
                .HasMaxLength(255)
                .HasColumnName("FinalGradeGPA");
            entity.Property(e => e.FinalGradeUgpa)
                .HasMaxLength(255)
                .HasColumnName("FinalGradeUGPA");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Grade1).HasMaxLength(255);
            entity.Property(e => e.Grade2).HasMaxLength(255);
            entity.Property(e => e.Grade3).HasMaxLength(255);
            entity.Property(e => e.Grade4).HasMaxLength(255);
            entity.Property(e => e.Grade5).HasMaxLength(255);
            entity.Property(e => e.Grade6).HasMaxLength(255);
            entity.Property(e => e.GradeLevel).HasMaxLength(255);
            entity.Property(e => e.Hs)
                .HasMaxLength(255)
                .HasColumnName("HS");
            entity.Property(e => e.Imported).HasMaxLength(255);
            entity.Property(e => e.Instructor).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyCourseId)
                .HasMaxLength(255)
                .HasColumnName("LegacyCourseID");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.OrigAbbreviation)
                .HasMaxLength(255)
                .HasColumnName("Orig_Abbreviation");
            entity.Property(e => e.Passing).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.SchoolName).HasMaxLength(255);
            entity.Property(e => e.Sem1Avg).HasMaxLength(255);
            entity.Property(e => e.Sem1Grade).HasMaxLength(255);
            entity.Property(e => e.Sem2Avg).HasMaxLength(255);
            entity.Property(e => e.Sem2Grade).HasMaxLength(255);
            entity.Property(e => e.SemesterId)
                .HasMaxLength(255)
                .HasColumnName("SemesterID");
            entity.Property(e => e.StateId)
                .HasMaxLength(255)
                .HasColumnName("StateID");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .HasColumnName("StudentID");
            entity.Property(e => e.SummerSchool).HasMaxLength(255);
            entity.Property(e => e.Tardy).HasMaxLength(255);
            entity.Property(e => e.Term1Average).HasMaxLength(255);
            entity.Property(e => e.Term2Average).HasMaxLength(255);
            entity.Property(e => e.Term3Average).HasMaxLength(255);
            entity.Property(e => e.Term4Average).HasMaxLength(255);
            entity.Property(e => e.Term5Average).HasMaxLength(255);
            entity.Property(e => e.Term6Average).HasMaxLength(255);
            entity.Property(e => e.TermId)
                .HasMaxLength(255)
                .HasColumnName("TermID");
            entity.Property(e => e.Transfer).HasMaxLength(255);
            entity.Property(e => e.YearId)
                .HasMaxLength(255)
                .HasColumnName("YearID");
            entity.Property(e => e.YearName).HasMaxLength(255);
        });

        modelBuilder.Entity<UdconfigBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__UDConfig__360414FFEE79A9A1");

            entity.ToTable("UDConfigBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.DistrictWide).HasMaxLength(255);
            entity.Property(e => e.FieldDataType).HasMaxLength(255);
            entity.Property(e => e.FieldName).HasMaxLength(255);
            entity.Property(e => e.FieldOrder).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.GroupOrder).HasMaxLength(255);
            entity.Property(e => e.GroupType).HasMaxLength(255);
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
        });

        modelBuilder.Entity<UddataBp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__UDDataBP__360414FF77BF2296");

            entity.ToTable("UDDataBP");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.ClassName).HasMaxLength(255);
            entity.Property(e => e.ClassSection).HasMaxLength(255);
            entity.Property(e => e.CourseAbbreviation).HasMaxLength(255);
            entity.Property(e => e.FamilyName).HasMaxLength(255);
            entity.Property(e => e.FieldName).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.GroupType).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LegacyPersonId)
                .HasMaxLength(255)
                .HasColumnName("LegacyPersonID");
            entity.Property(e => e.Rwid)
                .HasMaxLength(255)
                .HasColumnName("RWID");
            entity.Property(e => e.SchoolCode).HasMaxLength(255);
            entity.Property(e => e.SchoolId)
                .HasMaxLength(255)
                .HasColumnName("SchoolID");
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<UddataNotDefined>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UDDataNotDefined", "val");

            entity.Property(e => e.FieldName).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.GroupType).HasMaxLength(255);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
        });

        modelBuilder.Entity<ValidationConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ValidationConfiguration");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
