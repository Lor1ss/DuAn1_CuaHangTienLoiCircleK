using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class HoaDonChiTiet
{
    public int MaHoaDon { get; set; }

    public int IdSanPhamChiTiet { get; set; }

    public int? SoLuong { get; set; }

    public decimal? GiaBan { get; set; }

    public virtual SanPhamChiTiet IdSanPhamChiTietNavigation { get; set; } = null!;

    public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
}
