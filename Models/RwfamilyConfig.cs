using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwfamilyConfig
{
    public int FamilyId { get; set; }

    public string? FamilyName { get; set; }

    public string? FamilyName2 { get; set; }

    public string? FamilyLetter { get; set; }

    public bool? StandardFamily { get; set; }

    public bool? EnableWeb { get; set; }

    public int? Unlisted { get; set; }

    public int? Directory { get; set; }

    public bool? Accounting { get; set; }

    public string? FamilyEmail { get; set; }

    public string? AccountingCode { get; set; }

    public string? FamilyCode { get; set; }

    public string? Note { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? FamilyNameBp { get; set; }

    public int? FactsCustomerPersonId { get; set; }

    public bool ParentsWebFinancialBlock { get; set; }

    public int FactsUpdateState { get; set; }
}
