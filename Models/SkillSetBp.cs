using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class SkillSetBp
{
    public int RecId { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? SchoolCode { get; set; }

    public string? SubjectOrder { get; set; }

    public string? Subject { get; set; }

    public string? SkillOrder { get; set; }

    public string? Skill { get; set; }

    public string? SingleGrade { get; set; }
}
