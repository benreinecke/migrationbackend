using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class Rwudfield
{
    public int FieldId { get; set; }

    public int? GroupId { get; set; }

    public string? FieldName { get; set; }

    public int? FieldType { get; set; }

    public int? FieldOrder { get; set; }
}
