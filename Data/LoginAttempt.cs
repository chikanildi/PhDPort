using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class LoginAttempt
{
    public int Id { get; set; }

    public string IpAddress { get; set; } = null!;

    public bool? AttemptsLeft { get; set; }

    public DateTime Date { get; set; }
}
