using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class HinhThucThanhToan
{
    public int IdHinhThucThanhToan { get; set; }

    public string? TenHinhThucThanhToan { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
