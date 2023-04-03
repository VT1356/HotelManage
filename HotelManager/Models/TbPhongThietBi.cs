using System;
using System.Collections.Generic;

namespace HotelManager.Models;

public partial class TbPhongThietBi
{
    public int Idphong { get; set; }

    public int Idtb { get; set; }

    public int? Soluong { get; set; }

    public virtual TbThietBi IdtbNavigation { get; set; } = null!;
}
