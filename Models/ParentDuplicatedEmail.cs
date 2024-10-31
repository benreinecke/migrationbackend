using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ParentDuplicatedEmail
{
    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public int Id { get; set; }
}
