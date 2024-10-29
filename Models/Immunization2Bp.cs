using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Immunization2Bp
{
    public int RecId { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? ShotType { get; set; }

    public string? ShotDate { get; set; }

    public string? ShotNumber { get; set; }

    public string? ShotNote { get; set; }

    public string? Exemption { get; set; }
}
