using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffDenominationNotDefined
{
    public string? LegacyPersonId { get; set; }

    public string PersonCategory { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Denomination { get; set; }
}
