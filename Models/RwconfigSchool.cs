using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwconfigSchool
{
    public short? DaySchedule { get; set; }

    public string? SchoolName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public int? DefaultYearId { get; set; }

    public short? DefaultTermId { get; set; }

    public string? Web { get; set; }

    public string? Email { get; set; }

    public string SchoolCode { get; set; } = null!;

    public bool Active { get; set; }

    public string? DefaultTemplate { get; set; }

    public bool? RcTerm1 { get; set; }

    public bool? RcTerm2 { get; set; }

    public bool? RcTerm3 { get; set; }

    public bool? RcTerm4 { get; set; }

    public bool? RcTerm5 { get; set; }

    public bool? RcTerm6 { get; set; }

    public bool? RcSem1 { get; set; }

    public bool? RcSem2 { get; set; }

    public bool? RcExam1 { get; set; }

    public bool? RcExam2 { get; set; }

    public bool? RcFinalGrade { get; set; }

    public string? DistrictName { get; set; }

    public string? CollegeBoardSchoolCode { get; set; }

    public string? TranscriptNote1 { get; set; }

    public string? TranscriptNote2 { get; set; }

    public string? TranscriptNote3 { get; set; }

    public string? TranscriptNote4 { get; set; }

    public string? TranscriptNote5 { get; set; }

    public string? ReportCardNote1 { get; set; }

    public string? ReportCardNote2 { get; set; }

    public string? ReportCardNote3 { get; set; }

    public string? ReportCardNote4 { get; set; }

    public string? ReportCardNote5 { get; set; }

    public int? DayAttendanceSource { get; set; }

    public int? AbsentDay { get; set; }

    public int? AbsentHalf { get; set; }

    public int? TranscriptLoad { get; set; }

    public string? TranscriptT1suffix { get; set; }

    public string? TranscriptT2suffix { get; set; }

    public string? TranscriptT3suffix { get; set; }

    public string? TranscriptT4suffix { get; set; }

    public string? TranscriptT5suffix { get; set; }

    public string? TranscriptT6suffix { get; set; }

    public string? FamilyNameCouple1 { get; set; }

    public string? FamilyNameCouple2 { get; set; }

    public string? FamilyNameCouple3 { get; set; }

    public string? FamilyNameIndividual1 { get; set; }

    public string? FamilyNameIndividual2 { get; set; }

    public string? FamilyNameIndividual3 { get; set; }

    public string? LessonPlanLabel1 { get; set; }

    public string? LessonPlanLabel2 { get; set; }

    public string? LessonPlanLabel3 { get; set; }

    public string? LessonPlanLabel4 { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? PwyearId { get; set; }

    public int? PwtermId { get; set; }

    public string? NotificationEmail1 { get; set; }

    public string? NotificationEmail2 { get; set; }

    public DateTime? BeginWebLunch { get; set; }

    public DateTime? EndWebLunch { get; set; }

    public string? WebCourseRequestsCustomTemplate { get; set; }

    public bool? WebCourseRequestsFilterByGradeLevel { get; set; }

    public bool? WebCourseRequestsSortByDepartment { get; set; }

    public bool? WebCourseRequestsUsePrereqRules { get; set; }

    public bool? WebCourseRequestsShowHistory { get; set; }

    public bool? WebCourseRequestsUseNextYearGradeLevel { get; set; }

    public bool? WebCourseRequestsUseCustomTemplate { get; set; }

    public int? WebCourseRequestsYearId { get; set; }

    public int? PwtermId2 { get; set; }

    public string? Pwbanner { get; set; }

    public int? PwscheduleYearId { get; set; }

    public int? PwscheduleTermId { get; set; }

    public string? PwscheduleTemplate { get; set; }

    public bool? GbkTerm1 { get; set; }

    public bool? GbkTerm2 { get; set; }

    public bool? GbkTerm3 { get; set; }

    public bool? GbkTerm4 { get; set; }

    public bool? GbkTerm5 { get; set; }

    public bool? GbkTerm6 { get; set; }

    public bool? GbkCurrentYearEditOnly { get; set; }

    public int? NextYearId { get; set; }

    public int? LunchPaymentMethod { get; set; }

    public int? LunchAccountingSystemId { get; set; }

    public int? LunchFiscalYearId { get; set; }

    public int? LunchAccountingCategoryId { get; set; }

    public string? PwschoolName { get; set; }

    public string? PwmascotName { get; set; }

    public string? PwheaderColor1 { get; set; }

    public int? PwdefaultStaffIdforComments { get; set; }

    public string? PwheaderColor2 { get; set; }

    public string? PwheaderPicturePath { get; set; }

    public string? AttendancePolicy { get; set; }

    public string? BehaviorPolicy { get; set; }

    public string? PwtextColor { get; set; }

    public string? DonateNowContact { get; set; }

    public string? DonateNowMessage { get; set; }

    public bool? ParentAlert { get; set; }

    public short ConfigSchoolId { get; set; }

    public int? LibraryPolicyAccountingCategoryId { get; set; }

    public int? LibraryPolicyFiscalYearId { get; set; }

    public short LibraryPolicyLateFeeMode { get; set; }

    public int LibraryPolicyDefaultMaxCheckouts { get; set; }

    public bool LibraryPolicyDefaultBlockOnFines { get; set; }

    public int? OeAccountingSystemId { get; set; }

    public int? OeCategoryId { get; set; }

    public int? OeFiscalYearId { get; set; }

    public string? EnrollmentNotificationTemplateNewStudent { get; set; }

    public string? EnrollmentNotificationTemplateExistingStudent { get; set; }

    public int LibraryCalendarSettings { get; set; }

    public bool LibraryPolicyIsSchoolDays { get; set; }

    public int LibraryPolicyDefaultMaxHoldTime { get; set; }

    public int LibraryPolicyDefaultMaxReservations { get; set; }

    public int LibraryPolicyDefaultMaxReservationTime { get; set; }

    public int? EnrollmentYearId { get; set; }

    public int? OeTuitionPlanFiscalYearId { get; set; }

    public bool UseGradeLevelAttendanceConfiguration { get; set; }

    public int? Pwversion { get; set; }

    public bool RcSem3 { get; set; }

    public bool RcExam3 { get; set; }

    public bool SchoolLms { get; set; }

    public string? OefactsTerm { get; set; }

    public string? OefactsAccount { get; set; }

    public string? OefactsAdjustmentReason { get; set; }

    public string? OafactsTerm { get; set; }

    public string? OafactsAccount { get; set; }

    public string? OafactsAdjustmentReason { get; set; }

    public bool SchoolChat { get; set; }

    public bool ShowCalendar { get; set; }

    public bool ShowAnnouncements { get; set; }

    public Guid? TenantId { get; set; }

    public byte SchoolSortOrder { get; set; }

    public byte SystemOfMeasurement { get; set; }

    public bool ReportCardOnlyAllowSystemComments { get; set; }

    public byte ClockFormatId { get; set; }
}
