using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class CallForPaper
{
    public string Keywords { get; set; } = null!;

    public string TitleOfConf { get; set; } = null!;

    public DateTime PostSubmissionTime { get; set; }

    public DateTime TimeOfEventStart { get; set; }

    public DateTime TimeOfEventEnd { get; set; }

    public string Comment { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public string? Username { get; set; }

    public string UrlLink { get; set; } = null!;

    public int Id { get; set; }

    public int Institution { get; set; }

    public DateTime? SubmissionDeadline { get; set; }

    public int Isdeleted { get; set; }
}
