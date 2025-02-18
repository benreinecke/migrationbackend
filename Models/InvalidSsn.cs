﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class InvalidSsn
{
    public string PersonType { get; set; } = null!;

    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Ssn { get; set; }

    public int Id { get; set; }
}
