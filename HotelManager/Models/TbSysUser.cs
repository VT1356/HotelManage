using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbSysUser
{
    public int Uid { get; set; }

    public string? Fullname { get; set; }

    public string? Username { get; set; }

    public string? Passwd { get; set; }

    public string? Macty { get; set; }

    public string? Madvi { get; set; }

    public bool? Isgroup { get; set; }

    public bool? Disabled { get; set; }

    public virtual ICollection<TbDatPhong> TbDatPhongs { get; } = new List<TbDatPhong>();
}
