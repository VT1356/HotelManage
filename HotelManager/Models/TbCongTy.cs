using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbCongTy
{
    public string Macty { get; set; } = null!;

    public string? Tencty { get; set; }

    public string? Dienthoai { get; set; }

    public string? Email { get; set; }

    public string? Diachi { get; set; }
    public Boolean ? Disabled { get; set; }
    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();

    public virtual ICollection<TbDonVi> TbDonVis { get; } = new List<TbDonVi>();
}
