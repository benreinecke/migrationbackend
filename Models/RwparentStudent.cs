using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwparentStudent
{
    public int ParentId { get; set; }

    public int StudentId { get; set; }

    public bool? Custody { get; set; }

    public bool? Correspondence { get; set; }

    public string? Relationship { get; set; }

    public bool? Grandparent { get; set; }

    public bool? EmergencyContact { get; set; }

    public bool? ReportCard { get; set; }

    public bool? Pwblock { get; set; }

    public bool? PickUp { get; set; }

    public bool? ParentsWeb { get; set; }

    public bool? Reenroll { get; set; }
}
