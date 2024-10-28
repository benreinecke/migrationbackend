using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class ParentGenderIssue
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Relationship { get; set; }

    public string _ { get; set; } = null!;

    public string Issue { get; set; } = null!;
}
