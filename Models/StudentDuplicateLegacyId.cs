﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentDuplicateLegacyId
{
    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CellPhone { get; set; }

    public string? Email { get; set; }

    public int Id { get; set; }
}
