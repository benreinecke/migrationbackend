using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwgradeLevel
{
    public int GradeLevelId { get; set; }

    public bool FinalGradeLevel { get; set; }

    public string? GradDate { get; set; }

    public string GradeLevel { get; set; } = null!;

    public string? NextGradeLevel { get; set; }

    public string? ScheduleTemplate { get; set; }

    public string SchoolCode { get; set; } = null!;

    public string? NextSchoolCode { get; set; }

    public string? ReportCardTemplate { get; set; }

    public string? ProgressReportTemplate { get; set; }

    public string? TranscriptTemplate { get; set; }

    public bool? PreSchool { get; set; }

    public bool? Elementary { get; set; }

    public int? CurriculumPlanId { get; set; }

    public string? AttendanceMethod { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? CirculationLimit { get; set; }

    public int? CirculationPeriod { get; set; }

    public int? Capacity { get; set; }

    public bool? MiddleSchool { get; set; }

    public bool? HighSchool { get; set; }

    public string? Description { get; set; }

    public int? SortOrder { get; set; }

    public int? AdmissionTrackingId { get; set; }

    public int? ReenrollTrackingId { get; set; }

    public int? InquiryTrackingId { get; set; }

    public int? PatronGroupId { get; set; }

    public int AbsentHalf { get; set; }

    public int AbsentDay { get; set; }

    public Guid? GradeLevelDescriptorId { get; set; }
}
