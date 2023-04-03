using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbPhong
{
    public int Idphong { get; set; }

    public string? Tenphong { get; set; }

    public bool? Trangthai { get; set; }

    public int Idtang { get; set; }

    public int Idloaiphong { get; set; }

    public virtual TbLoaiPhong TbLoaiPhong { get; set; } 

    public virtual TbTang TbTang { get; set; } 

    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();
}
