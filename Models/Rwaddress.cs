using System;
using System.Collections.Generic;

namespace DataConversionAPI.Models;

public partial class Rwaddress
{
    public int AddressId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Greeting1 { get; set; }

    public string? Greeting2 { get; set; }

    public string? Greeting3 { get; set; }

    public string? Greeting4 { get; set; }

    public string? Greeting5 { get; set; }

    public int? NewStudentInquiryId { get; set; }
}
