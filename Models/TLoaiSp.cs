﻿using System;
using System.Collections.Generic;

namespace WebApplication8.Models;

public partial class TLoaiSp
{
    public string MaLoai { get; set; } = null!;

    public string? Loai { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; } = new List<TDanhMucSp>();
}
