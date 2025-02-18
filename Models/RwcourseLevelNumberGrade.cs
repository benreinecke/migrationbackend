﻿using System;
using System.Collections.Generic;

namespace web_api_nelnet.Models;

public partial class RwcourseLevelNumberGrade
{
    public string? LevelName { get; set; }

    public string? Description { get; set; }

    public int CourseLevelId { get; set; }

    public string? Schoolcode { get; set; }

    public decimal? Average { get; set; }

    public decimal? Gpa { get; set; }

    public decimal? Ugpa { get; set; }

    public bool Passing { get; set; }

    public bool Calc { get; set; }
}
