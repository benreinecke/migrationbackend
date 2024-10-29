using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ClassLessonPlanBp
{
    public int RecId { get; set; }

    public string? Abbreviation { get; set; }

    public string? Section { get; set; }

    public string? PlanDate { get; set; }

    public string? LessonPlan { get; set; }

    public string? Homework { get; set; }

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Text3 { get; set; }

    public string? Text4 { get; set; }

    public string? Comments { get; set; }
}
