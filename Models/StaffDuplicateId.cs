﻿using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class StaffDuplicateId
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? CellPhone { get; set; }

    public string? Email { get; set; }
}
