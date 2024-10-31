using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffNoGradeLevelsAssigned
{
    public string? SchoolCode { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Ps { get; set; }

    public string? Elem { get; set; }

    public string? Ms { get; set; }

    public string? Hs { get; set; }

    public int Id { get; set; }
}
