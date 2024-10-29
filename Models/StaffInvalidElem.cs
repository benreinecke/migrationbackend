using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffInvalidElem
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FamilyName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Elem { get; set; }
}
