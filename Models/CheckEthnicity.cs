using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class CheckEthnicity
{
    public string ValueCategory { get; set; } = null!;

    public string? Ethnicity { get; set; }

    public string InDefinedList { get; set; } = null!;

    public string NewValue { get; set; } = null!;
}
