using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffecBp
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? StaffFirstName { get; set; }

    public string? StaffLastName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Relationship { get; set; }

    public string? HomePhone { get; set; }

    public string? CellPhone { get; set; }

    public string? WorkPhone { get; set; }

    public string? Email { get; set; }

    public string? Note { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }
}
