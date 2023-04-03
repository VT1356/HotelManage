using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbDatPhong
{
    public int Id { get; set; }

    public int? Idkh { get; set; }

    public int? Idphong { get; set; }

    public DateTime? Ngaydat { get; set; }

    public DateTime? Ngaytra { get; set; }

    public int? Songayo { get; set; }

    public int? Uid { get; set; }

    public int? Idsp { get; set; }

    public string? Macty { get; set; }

    public string? Madvi { get; set; }
    // public DateTime? CreatedDate { get; set; }

    //public DateTime? UpdateDate { get; set; }
    //public string? UpdateBy { get; set; }
    //public bool? Trangthai { get; set; }

    public virtual TbKhachHang? TbKhachHang { get; set; }

    public virtual TbPhong? TbPhong { get; set; }

    public virtual TbSanPham? TbSanPham { get; set; }

    public virtual TbCongTy? TbCongTy { get; set; }

    public virtual TbDonVi? TbDonVi { get; set; }

    public virtual TbSysUser? TbSysUser { get; set; }
}
