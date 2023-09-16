using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string ActivationCode { get; set; } = null!;

    public string Rememberme { get; set; } = null!;

    public string Reset { get; set; } = null!;

    public DateTime Registered { get; set; }

    public DateTime LastSeen { get; set; }

    public string TfaCode { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public int Userstatus { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Aboutme { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Affiliation { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Countryoforigin { get; set; }

    public string Language { get; set; } = null!;

    public string Researchinterest { get; set; } = null!;

    public int Isdeleted { get; set; }
}
