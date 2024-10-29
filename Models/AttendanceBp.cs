using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class AttendanceBp
{
    public int RecId { get; set; }

    public string? SchoolId { get; set; }

    public string? Abbreviation { get; set; }

    public string? Section { get; set; }

    public string? Column { get; set; }

    public string? AttendanceDate { get; set; }

    public string? AttendanceCode { get; set; }

    public string? AttendanceCodeName { get; set; }

    public string? Comment { get; set; }
}
