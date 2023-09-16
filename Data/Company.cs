using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
}
