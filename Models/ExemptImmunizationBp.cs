using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class ExemptImmunizationBp
{
    public int RecId { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Dtp0 { get; set; }

    public string? HepA0 { get; set; }

    public string? HepB0 { get; set; }

    public string? Hib0 { get; set; }

    public string? Hpv0 { get; set; }

    public string? Influezena0 { get; set; }

    public string? MenAcwy0 { get; set; }

    public string? MenB0 { get; set; }

    public string? Mmr0 { get; set; }

    public string? Pneumococcal0 { get; set; }

    public string? Polio0 { get; set; }

    public string? Tdap0 { get; set; }

    public string? Varicella0 { get; set; }
}
