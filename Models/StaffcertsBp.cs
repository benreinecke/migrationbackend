using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffcertsBp
{
    public int RecId { get; set; }

    public string? LegacyPersonid { get; set; }

    public string? Staffid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Certification { get; set; }

    public string? Certificationlevel { get; set; }

    public string? Expiration { get; set; }

    public string? Notes { get; set; }

    public string? Date { get; set; }

    public string? Description { get; set; }

    public string? Hours { get; set; }

    public string? Ceu { get; set; }

    public string? CertLevel { get; set; }
}
