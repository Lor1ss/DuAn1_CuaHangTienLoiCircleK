using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class SanPham
{
    public int IdSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public decimal? GiaBan { get; set; }

    public int? IdKhuyenMai { get; set; }

    public virtual KhuyenMai? IdKhuyenMaiNavigation { get; set; }

    public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; } = new List<PhieuNhapHang>();

    public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
}
