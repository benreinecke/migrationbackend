﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RaceBp
{
    public int RecId { get; set; }

    public string? Studentid { get; set; }

    public string? Schoolid { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? Race { get; set; }
}
