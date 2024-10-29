using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web_api_nelnet.Models;

public partial class InvalidPhoneNumber
{
    public string PersonType { get; set; } = null!;

    [Key]
    public int RecId { get; set; }

    public string? LegacyPersonId { get; set; }

    public string Field { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}
