using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ConversionTranslation
{
    public string Type { get; set; } = null!;

    public string From { get; set; } = null!;

    public string To { get; set; } = null!;
}
