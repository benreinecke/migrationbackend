using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Rwdefinedlist
{
    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? SchoolCode { get; set; }

    public bool DefaultField { get; set; }

    public int Dlid { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte SortOrder { get; set; }
}
