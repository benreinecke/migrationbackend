using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class MedicalGeneralNoPerson
{
    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int Id { get; set; }
}
