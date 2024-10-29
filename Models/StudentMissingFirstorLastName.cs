using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentMissingFirstorLastName
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }
}
