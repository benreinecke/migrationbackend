﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class InvalidSchoolCode
{
    public string PersonType { get; set; } = null!;

    public int RecId { get; set; }

    public string LegacyPersonId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SchoolCode { get; set; }

    public int Id { get; set; }
}
