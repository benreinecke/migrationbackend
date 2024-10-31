using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class LockerDuplicateNumber
{
    public string? Locker { get; set; }

    public int? Occurrences { get; set; }

    public int Id { get; set; }
}
