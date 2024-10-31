using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffOccupationNotInDefaultList
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Occupation { get; set; }

    public int Id { get; set; }
}
