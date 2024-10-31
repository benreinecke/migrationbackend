using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentGenderNotInStandard
{
    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public int Id { get; set; }
}
