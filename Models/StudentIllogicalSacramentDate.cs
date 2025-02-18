﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class StudentIllogicalSacramentDate
{
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? Date { get; set; }

    public string DateType { get; set; } = null!;

    public int Id { get; set; }
}
