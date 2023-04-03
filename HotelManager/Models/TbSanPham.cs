using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbSanPham
{
    public int Idsp { get; set; }

    public string? Tensp { get; set; }

    public double? Dongia { get; set; }

    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();
}
