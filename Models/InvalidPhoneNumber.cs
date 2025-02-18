﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class InvalidPhoneNumber
{
    public string? PhoneNumber { get; set; }

    public string PersonType { get; set; } = null!;

    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string Field { get; set; } = null!;

    public int Id { get; set; }
}
