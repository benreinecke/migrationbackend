﻿using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class ParentDuplicatedEmail
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }
}
