using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentTransportationBp
{
    public int RecId { get; set; }

    public string? SchoolCode { get; set; }

    public string? StudentId { get; set; }

    public string? SchoolId { get; set; }

    public string? BusRoute { get; set; }

    public string? RouteType { get; set; }

    public string? Monday { get; set; }

    public string? Tuesday { get; set; }

    public string? Wednesday { get; set; }

    public string? Thursday { get; set; }

    public string? Friday { get; set; }

    public string? Saturday { get; set; }

    public string? Sunday { get; set; }

    public string? Note { get; set; }
}
