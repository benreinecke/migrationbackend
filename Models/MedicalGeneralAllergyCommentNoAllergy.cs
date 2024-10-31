using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class MedicalGeneralAllergyCommentNoAllergy
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AllergyComment { get; set; }

    public string? Allergy { get; set; }

    public int Id { get; set; }
}
