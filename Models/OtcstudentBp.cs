using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class OtcstudentBp
{
    public int RecId { get; set; }

    public string? Schoolcode { get; set; }

    public string? Schoolid { get; set; }

    public string? Otcmedication { get; set; }

    public string? SelfAdminister { get; set; }

    public string? Note { get; set; }
}
