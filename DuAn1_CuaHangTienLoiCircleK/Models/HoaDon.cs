using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class HoaDon
{
    public int MaHoaDon { get; set; }

    public int? MaKhachHang { get; set; }

    public int? IdNhanVien { get; set; }

    public int? IdHinhThucThanhToan { get; set; }

    public DateOnly? NgayBan { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual HinhThucThanhToan? IdHinhThucThanhToanNavigation { get; set; }

    public virtual NhanVien? IdNhanVienNavigation { get; set; }

    public virtual KhachHang? MaKhachHangNavigation { get; set; }
}
