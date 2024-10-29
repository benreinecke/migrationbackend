using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class CommunityServiceStudentBp
{
    public int RecId { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? Day { get; set; }

    public string? Description { get; set; }

    public string? HoursWorked { get; set; }

    public string? Location { get; set; }

    public string? Note { get; set; }
}
