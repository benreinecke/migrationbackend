using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class MasterLessonPlanBp
{
    public int RecId { get; set; }

    public string? Abbreviation { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Day { get; set; }

    public string? LessonPlan { get; set; }

    public string? Homework { get; set; }

    public string? Details1 { get; set; }

    public string? Details2 { get; set; }

    public string? Details3 { get; set; }

    public string? Details4 { get; set; }
}
