﻿using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class StudentGenderNotInStandard
{
    public int RecId { get; set; }

    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }
}
