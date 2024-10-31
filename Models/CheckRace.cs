using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class CheckRace
{
    public string ValueCategory { get; set; } = null!;

    public string? Race { get; set; }

    public string InDefinedList { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public int Id { get; set; }
}
