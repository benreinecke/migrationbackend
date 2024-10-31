using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffInvalidDate
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public int Id { get; set; }
}
