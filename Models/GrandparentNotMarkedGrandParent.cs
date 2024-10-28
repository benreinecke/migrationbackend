using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class GrandparentNotMarkedGrandParent
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Relationship { get; set; }

    public string? Grandparent { get; set; }
}
