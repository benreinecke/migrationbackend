﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class IndividualNoRight
{
    public string? FamilyName { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Relationship { get; set; }

    public string? Custody { get; set; }

    public string? FinancialResponsibility { get; set; }

    public string? Correspondence { get; set; }

    public string? ParentsWeb { get; set; }

    public string? ReportCard { get; set; }

    public string? EmergencyContact { get; set; }

    public string? Pickup { get; set; }

    public string? Grandparent { get; set; }

    public int Id { get; set; }
}
