using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class PhieuNhapHang
{
    public int MaNhapHang { get; set; }

    public int? IdSanPham { get; set; }

    public int? IdNhanVien { get; set; }

    public string? TenSanPham { get; set; }

    public DateOnly? NgayNhap { get; set; }

    public int? SoLuong { get; set; }

    public decimal? GiaBan { get; set; }

    public virtual NhanVien? IdNhanVienNavigation { get; set; }

    public virtual SanPham? IdSanPhamNavigation { get; set; }
}
