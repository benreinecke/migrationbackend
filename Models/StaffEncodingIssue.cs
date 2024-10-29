using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffEncodingIssue
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }
}
