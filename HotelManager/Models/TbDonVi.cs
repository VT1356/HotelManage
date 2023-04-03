using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbDonVi
{
    public string Madvi { get; set; } = null!;

    public string? Tendvi { get; set; }

    public string? Dienthoai { get; set; }

    public string? Email { get; set; }

    public string? Diachi { get; set; }

    public string? Macty { get; set; }

    public virtual TbCongTy? TbCongTy { get; set; }

    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();
}
