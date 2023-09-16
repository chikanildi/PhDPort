using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class Bookmark
{
    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public string BmDataSource { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? FilePath { get; set; }

    public string? Keywords { get; set; }

    public DateTime CreatedAt { get; set; }
}
