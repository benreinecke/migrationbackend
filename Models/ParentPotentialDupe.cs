using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ParentPotentialDupe
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Relationship { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? HomePhone { get; set; }

    public string? WorkPhone { get; set; }

    public string? CellPhone { get; set; }
}
