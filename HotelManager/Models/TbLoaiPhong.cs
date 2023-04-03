using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbLoaiPhong
{
    public int Idloaiphong { get; set; }

    public string? Tenloaiphong { get; set; }

    public double? Dongia { get; set; }

    public int? Songuoi { get; set; }

    public int Soluong { get; set; }

    public virtual ICollection<TbPhong> TbPhongs { get; } = new List<TbPhong>();
}
