using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbTang
{
    public int Idtang { get; set; }

    public string? Tentang { get; set; }

    public virtual ICollection<TbPhong> TbPhongs { get; } = new List<TbPhong>();
}
