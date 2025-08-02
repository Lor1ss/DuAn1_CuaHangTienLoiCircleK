using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class SanPhamChiTiet
{
    public int IdSanPhamChiTiet { get; set; }

    public int? IdSanPham { get; set; }

    public DateOnly? HanSuDung { get; set; }

    public int? SoLuong { get; set; }

    public string? DonViTinh { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual SanPham? IdSanPhamNavigation { get; set; }
}
