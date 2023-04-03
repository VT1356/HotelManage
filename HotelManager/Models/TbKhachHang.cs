using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbKhachHang
{
    public int Idkh { get; set; }

    public string? Hoten { get; set; }

    public string? Cccd { get; set; }

    public string? Dienthoai { get; set; }

    public string? Email { get; set; }

    public string? Diachi { get; set; }

    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();
}
