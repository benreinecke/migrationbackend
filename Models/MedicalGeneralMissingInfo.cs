﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class MedicalGeneralMissingInfo
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Allergy { get; set; }

    public string? Medication { get; set; }

    public string? Condition { get; set; }

    public int Id { get; set; }
}
