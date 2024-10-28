using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class MedicalGeneralBp
{
    public int RecId { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Condition { get; set; }

    public string? ConditionComment { get; set; }

    public string? Allergy { get; set; }

    public string? AllergyComment { get; set; }

    public string? Medication { get; set; }

    public string? MedicationComment { get; set; }

    public string? Dose { get; set; }

    public string? SelfAdminister { get; set; }

    public string? DatePrescribed { get; set; }

    public string? Scheduled { get; set; }
}
