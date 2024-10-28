using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class MedicalGeneralInvalidDate
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? DatePrescribed { get; set; }
}
