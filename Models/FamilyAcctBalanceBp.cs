﻿using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class FamilyAcctBalanceBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? FamilyName { get; set; }

    public string? Balance { get; set; }

    public string? FiscalYearName { get; set; }
}
