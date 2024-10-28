using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class InvalidSchoolCode
{
    public string PersonType { get; set; } = null!;

    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SchoolCode { get; set; }
}
