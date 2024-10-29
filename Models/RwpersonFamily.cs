using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwpersonFamily
{
    public int PersonId { get; set; }

    public int FamilyId { get; set; }

    public bool? Parent { get; set; }

    public bool? Student { get; set; }

    public bool? FinancialResponsibility { get; set; }

    public string? FinancialResponsibilityPercent { get; set; }

    public int? FamilyOrder { get; set; }

    public bool FactsCustomer { get; set; }
}
