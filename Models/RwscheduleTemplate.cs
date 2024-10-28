using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class RwscheduleTemplate
{
    public int YearId { get; set; }

    public string TemplateName { get; set; } = null!;

    public bool? Preschool { get; set; }

    public bool? Elementary { get; set; }

    public bool? MiddleSchool { get; set; }

    public bool? HighSchool { get; set; }

    public int TemplateId { get; set; }

    public int? Rows { get; set; }

    public int? Cols { get; set; }

    public bool Locked { get; set; }

    public int? CreatedById { get; set; }
}
