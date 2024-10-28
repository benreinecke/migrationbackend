using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class StudentNoFamily
{
    public int RecId { get; set; }

    public string? FamilyName { get; set; }

    public string? SchoolId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
