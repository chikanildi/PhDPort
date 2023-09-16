using System;
using System.Collections.Generic;

namespace Phd_Port.Data;

public partial class UploadDetail
{
    public int Id { get; set; }

    public string DataSource { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public string UrlLink { get; set; } = null!;

    public string Keywords { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public bool? Favorite { get; set; }

    public int PostedBy { get; set; }

    public int Isdeleted { get; set; }
}
