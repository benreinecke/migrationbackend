using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffRaceNotInStandard
{
    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Race { get; set; }

    public int Id { get; set; }
}
