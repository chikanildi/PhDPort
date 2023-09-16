using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Setting
{
    public int Id { get; set; }

    public string SettingKey { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public string Category { get; set; } = null!;
}
