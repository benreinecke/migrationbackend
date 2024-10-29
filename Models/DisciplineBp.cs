using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class DisciplineBp
{
    public int RecId { get; set; }

    public string? SchoolId { get; set; }

    public string? StudentId { get; set; }

    public string? DateOfIncident { get; set; }

    public string? Violation { get; set; }

    public string? DescriptionOfIncident { get; set; }

    public string? History { get; set; }

    public string? StaffId { get; set; }

    public string? Sanction1 { get; set; }

    public string? Sanction2 { get; set; }

    public string? SanctionDate1 { get; set; }

    public string? SanctionDate2 { get; set; }

    public string? Status { get; set; }

    public string? Demerits { get; set; }

    public string? Type { get; set; }

    public string? Level { get; set; }
}
