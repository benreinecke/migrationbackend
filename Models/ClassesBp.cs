using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ClassesBp
{
    public int RecId { get; set; }

    public string? Legacyclassid { get; set; }

    public string? OrigAbbreviation { get; set; }

    public string? Abbreviation { get; set; }

    public string? Name { get; set; }

    public string? Section { get; set; }

    public string? Legacypersonid { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AltLegacyPersonid { get; set; }

    public string? AltFirstName { get; set; }

    public string? AltLastName { get; set; }

    public string? Term1 { get; set; }

    public string? Term2 { get; set; }

    public string? Term3 { get; set; }

    public string? Term4 { get; set; }

    public string? Term5 { get; set; }

    public string? Term6 { get; set; }

    public string? Room { get; set; }

    public string? Template { get; set; }

    public string? Pattern { get; set; }

    public string? YearId { get; set; }
}
