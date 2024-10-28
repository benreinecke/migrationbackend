using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class InvalidDate
{
    public string PersonType { get; set; } = null!;

    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string Field { get; set; } = null!;

    public string? Date { get; set; }
}
