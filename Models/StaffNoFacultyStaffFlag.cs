﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StaffNoFacultyStaffFlag
{
    public string? SchoolCode { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Faculty { get; set; }

    public string? Staff { get; set; }

    public int Id { get; set; }
}
