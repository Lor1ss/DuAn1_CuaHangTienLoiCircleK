using System;
using System.Collections.Generic;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class ChamCong
{
    public int MaChamCong { get; set; }

    public int? MaNhanVien { get; set; }

    public DateOnly? NgayLamViec { get; set; }

    public TimeOnly? GioVaoCa { get; set; }

    public TimeOnly? GioRaCa { get; set; }

    public string? GhiChu { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
