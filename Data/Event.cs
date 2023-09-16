using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Eventtype { get; set; } = null!;

    public string Organizer { get; set; } = null!;

    public string Eventlocation { get; set; } = null!;

    public string Eventdescription { get; set; } = null!;

    public string Mode { get; set; } = null!;

    public string Fee { get; set; } = null!;

    public string? Keywords { get; set; }

    public string Eventurl { get; set; } = null!;

    public DateTime Dateend { get; set; }

    public DateTime Datestart { get; set; }

    public DateTime SubmitDate { get; set; }

    public string PostedBy { get; set; } = null!;

    public int Isdeleted { get; set; }

    public string? FavText { get; set; }
}
