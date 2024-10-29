using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class UddataBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? Rwid { get; set; }

    public string? GroupType { get; set; }

    public string? GroupName { get; set; }

    public string? FieldName { get; set; }

    public string? Value { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SchoolId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FamilyName { get; set; }

    public string? CourseAbbreviation { get; set; }

    public string? ClassName { get; set; }

    public string? ClassSection { get; set; }
}
