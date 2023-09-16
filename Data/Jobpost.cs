using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Jobpost
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public string Institution { get; set; } = null!;

    public string Jobtitle { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Salary { get; set; } = null!;

    public DateTime Posteddate { get; set; }

    public string Jobdescription { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime Deadline { get; set; }

    public string? Keywords { get; set; }

    public int IsDeleted { get; set; }
}
