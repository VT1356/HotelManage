using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbThietBi
{
    public int Idtb { get; set; }

    public string? Tentb { get; set; }

    public double? Dongia { get; set; }

    public virtual ICollection<TbPhongThietBi> TbPhongThietBis { get; } = new List<TbPhongThietBi>();
}
