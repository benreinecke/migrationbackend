using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class MedicalGeneralMissingInfo
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Allergy { get; set; }

    public string? Medication { get; set; }

    public string? Condition { get; set; }
}
