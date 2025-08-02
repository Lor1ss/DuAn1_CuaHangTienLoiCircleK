using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class KhuyenMai
{
    public int IdKhuyenMai { get; set; }

    public string? TenKhuyenMai { get; set; }

    public double? PhanTramKhuyenMai { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public string? DieuKienApDung { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
