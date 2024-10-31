using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ParentMissingFirstorLastName
{
    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FamilyOrder { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int Id { get; set; }
}
