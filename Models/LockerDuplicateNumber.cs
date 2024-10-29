using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class LockerDuplicateNumber
{
    public int RecId { get; set; }

    public string? Locker { get; set; }

    public int? Occurrences { get; set; }
}
