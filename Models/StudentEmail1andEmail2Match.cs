using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentEmail1andEmail2Match
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }
}
