﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class EcverifyRelationship
{
    public string? FamilyName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Relationship { get; set; }

    public int Id { get; set; }
}
