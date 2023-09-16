using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Director
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surename { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
