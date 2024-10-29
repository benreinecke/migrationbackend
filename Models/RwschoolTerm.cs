using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwschoolTerm
{
    public short TermId { get; set; }

    public int YearId { get; set; }

    public string? Name { get; set; }

    public DateTime? FirstDay { get; set; }

    public DateTime? LastDay { get; set; }

    public string? SchoolCode { get; set; }

    public bool Semester1 { get; set; }

    public bool Semester2 { get; set; }

    public int? SemesterId { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int SchoolTermId { get; set; }
}
