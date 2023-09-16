using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class User
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string Affiliation { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string ResearchInterest { get; set; } = null!;

    public string Aboutme { get; set; } = null!;

    public string Twitter { get; set; } = null!;

    public string Facebook { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime DateAdded { get; set; }

    public int Userstatus { get; set; }

    public virtual ICollection<Director> Directors { get; set; } = new List<Director>();
}
