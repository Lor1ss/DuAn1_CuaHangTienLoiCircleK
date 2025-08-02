using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_CuaHangTienLoiCircleK.Models;

public partial class CuaHangTienLoiCircleKContext : DbContext
{
    public CuaHangTienLoiCircleKContext()
    {
    }

    public CuaHangTienLoiCircleKContext(DbContextOptions<CuaHangTienLoiCircleKContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChamCong> ChamCongs { get; set; }

    public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SQ7JONV\\SQLEXPRESS;Database=CuaHangTienLoi_CircleK;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChamCong>(entity =>
        {
            entity.HasKey(e => e.MaChamCong).HasName("PK__ChamCong__307331A192138C27");

            entity.ToTable("ChamCong");

            entity.Property(e => e.GhiChu).HasMaxLength(255);

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.ChamCongs)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK__ChamCong__MaNhan__5070F446");
        });

        modelBuilder.Entity<HinhThucThanhToan>(entity =>
        {
            entity.HasKey(e => e.IdHinhThucThanhToan).HasName("PK__HinhThuc__4E2F5D7F4E49D391");

            entity.ToTable("HinhThucThanhToan");

            entity.Property(e => e.IdHinhThucThanhToan).HasColumnName("ID_HinhThucThanhToan");
            entity.Property(e => e.TenHinhThucThanhToan).HasMaxLength(50);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13B171B92C2");

            entity.ToTable("HoaDon");

            entity.Property(e => e.IdHinhThucThanhToan).HasColumnName("ID_HinhThucThanhToan");
            entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdHinhThucThanhToanNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdHinhThucThanhToan)
                .HasConstraintName("FK__HoaDon__ID_HinhT__49C3F6B7");

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("FK__HoaDon__ID_NhanV__48CFD27E");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK__HoaDon__MaKhachH__47DBAE45");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaHoaDon, e.IdSanPhamChiTiet }).HasName("PK__HoaDonCh__F29E46B2BD4422F4");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.IdSanPhamChiTiet).HasColumnName("ID_SanPhamChiTiet");
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdSanPhamChiTietNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdSanPhamChiTiet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__ID_Sa__4D94879B");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaHoa__4CA06362");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E57A5A0F87");

            entity.ToTable("KhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
            entity.HasKey(e => e.IdKhuyenMai).HasName("PK__KhuyenMa__E93749B42F3A610A");

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.IdKhuyenMai).HasColumnName("ID_KhuyenMai");
            entity.Property(e => e.DieuKienApDung).HasMaxLength(255);
            entity.Property(e => e.TenKhuyenMai).HasMaxLength(100);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNhanVien).HasName("PK__NhanVien__EF603D1221FA4FC2");

            entity.ToTable("NhanVien");

            entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
            entity.Property(e => e.TenNhanVien).HasMaxLength(100);
        });

        modelBuilder.Entity<PhieuNhapHang>(entity =>
        {
            entity.HasKey(e => e.MaNhapHang).HasName("PK__PhieuNha__42ECBDEA771D282B");

            entity.ToTable("PhieuNhapHang");

            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IdNhanVien).HasColumnName("ID_NhanVien");
            entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.PhieuNhapHangs)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("FK__PhieuNhap__ID_Nh__412EB0B6");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.PhieuNhapHangs)
                .HasForeignKey(d => d.IdSanPham)
                .HasConstraintName("FK__PhieuNhap__ID_Sa__403A8C7D");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__617EA3929F1EF079");

            entity.ToTable("SanPham");

            entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IdKhuyenMai).HasColumnName("ID_KhuyenMai");
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.IdKhuyenMaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdKhuyenMai)
                .HasConstraintName("FK__SanPham__ID_Khuy__38996AB5");
        });

        modelBuilder.Entity<SanPhamChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdSanPhamChiTiet).HasName("PK__SanPhamC__1C097896E205C755");

            entity.ToTable("SanPhamChiTiet");

            entity.Property(e => e.IdSanPhamChiTiet).HasColumnName("ID_SanPhamChiTiet");
            entity.Property(e => e.DonViTinh).HasMaxLength(50);
            entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");
            entity.Property(e => e.MoTa).HasMaxLength(255);

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.SanPhamChiTiets)
                .HasForeignKey(d => d.IdSanPham)
                .HasConstraintName("FK__SanPhamCh__ID_Sa__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
