using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class MedicalGeneralNoPerson
{
    public int RecId { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
