﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffDuplicateId
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? CellPhone { get; set; }

    public string? Email { get; set; }

    public int Id { get; set; }
}
