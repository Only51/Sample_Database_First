using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sample_Database_First.Models.DB
{
    public partial class Nanu_NewDesignContext : DbContext
    {
        public Nanu_NewDesignContext()
        {
        }

        public Nanu_NewDesignContext(DbContextOptions<Nanu_NewDesignContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDatHang> ChiTietDatHang { get; set; }
        public virtual DbSet<ChiTietKhsx> ChiTietKhsx { get; set; }
        public virtual DbSet<DinhMucNguyenLieu> DinhMucNguyenLieu { get; set; }
        public virtual DbSet<DinhMucNpl> DinhMucNpl { get; set; }
        public virtual DbSet<DinhMucPhuLieu> DinhMucPhuLieu { get; set; }
        public virtual DbSet<DonGia> DonGia { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<KeHoachNhapBtp> KeHoachNhapBtp { get; set; }
        public virtual DbSet<KeHoachSx> KeHoachSx { get; set; }
        public virtual DbSet<KetTest> KetTest { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<PhieuNhapXuatKho> PhieuNhapXuatKho { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<SanPhamNhapXuatKho> SanPhamNhapXuatKho { get; set; }
        public virtual DbSet<SoLanIn> SoLanIn { get; set; }
        public virtual DbSet<TaiLieu> TaiLieu { get; set; }
        public virtual DbSet<YeuCauGiaoHang> YeuCauGiaoHang { get; set; }
        public virtual DbSet<YeuCauSx> YeuCauSx { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ONLYMYSELF90;Initial Catalog=Nanu_NewDesign;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDatHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.ChiTietDatHang)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietDatHang_HopDong");
            });

            modelBuilder.Entity<ChiTietKhsx>(entity =>
            {
                entity.ToTable("ChiTietKHSX");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chuyen).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.KeHoachId).HasColumnName("KeHoach_ID");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.HasOne(d => d.KeHoach)
                    .WithMany(p => p.ChiTietKhsx)
                    .HasForeignKey(d => d.KeHoachId)
                    .HasConstraintName("FK_ChiTietKHSX_KeHoachSX");
            });

            modelBuilder.Entity<DinhMucNguyenLieu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DinhMucNplId).HasColumnName("DinhMucNPL_ID");

                entity.Property(e => e.Dvt)
                    .HasColumnName("DVT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MauMuc).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.SldonHang).HasColumnName("SLDonHang");

                entity.Property(e => e.TenNl)
                    .HasColumnName("TenNL")
                    .HasMaxLength(50);

                entity.Property(e => e.ViTriIn).HasMaxLength(50);

                entity.HasOne(d => d.DinhMucNpl)
                    .WithMany(p => p.DinhMucNguyenLieu)
                    .HasForeignKey(d => d.DinhMucNplId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinhMucNguyenLieu_DinhMucNPL");
            });

            modelBuilder.Entity<DinhMucNpl>(entity =>
            {
                entity.ToTable("DinhMucNPL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.DinhMucNpl)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinhMucNPL_HopDong");
            });

            modelBuilder.Entity<DinhMucPhuLieu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DinhMucNplId).HasColumnName("DinhMucNPL_ID");

                entity.Property(e => e.Dmsp).HasColumnName("DMSP");

                entity.Property(e => e.Dvt)
                    .HasColumnName("DVT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.TenPl)
                    .HasColumnName("TenPL")
                    .HasMaxLength(50);

                entity.HasOne(d => d.DinhMucNpl)
                    .WithMany(p => p.DinhMucPhuLieu)
                    .HasForeignKey(d => d.DinhMucNplId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinhMucPhuLieu_DinhMucNPL");
            });

            modelBuilder.Entity<DonGia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChiTietDatHangId).HasColumnName("ChiTietDatHang_ID");

                entity.Property(e => e.DonGia1).HasColumnName("DonGia");

                entity.Property(e => e.TenDonGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChiTietDatHang)
                    .WithMany(p => p.DonGia)
                    .HasForeignKey(d => d.ChiTietDatHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonGia_ChiTietDatHang");
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChucDanh).HasMaxLength(20);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.KhId).HasColumnName("KH_ID");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(30);

                entity.Property(e => e.NganHang).HasMaxLength(30);

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.NgayKi).HasColumnType("date");

                entity.Property(e => e.NguoiLienHe).HasMaxLength(30);

                entity.Property(e => e.NhanVien).HasMaxLength(30);

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.TyGia).HasColumnType("money");

                entity.HasOne(d => d.Kh)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.KhId)
                    .HasConstraintName("FK_HopDong_KhachHang");
            });

            modelBuilder.Entity<KeHoachNhapBtp>(entity =>
            {
                entity.ToTable("KeHoachNhapBTP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayDuKien).HasColumnType("date");

                entity.Property(e => e.TinhTrang).HasMaxLength(50);

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.KeHoachNhapBtp)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeHoachNhapBTP_HopDong");
            });

            modelBuilder.Entity<KeHoachSx>(entity =>
            {
                entity.ToTable("KeHoachSX");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.SlchuaSx).HasColumnName("SLChuaSX");

                entity.Property(e => e.SldaSx).HasColumnName("SLDaSX");

                entity.Property(e => e.SlyeuCauSx).HasColumnName("SLYeuCauSX");

                entity.Property(e => e.TenCty).HasMaxLength(50);

                entity.Property(e => e.YeuCauId).HasColumnName("YeuCau_ID");

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.KeHoachSx)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeHoachSX_HopDong");

                entity.HasOne(d => d.YeuCau)
                    .WithMany(p => p.KeHoachSx)
                    .HasForeignKey(d => d.YeuCauId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeHoachSX_YeuCauSX");
            });

            modelBuilder.Entity<KetTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FileKq)
                    .HasColumnName("FileKQ")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.Loai).HasMaxLength(10);

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.TinhTrang).HasMaxLength(100);

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.KetTest)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KetTest_HopDong");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(10);

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NvphuTrach)
                    .HasColumnName("NVPhuTrach")
                    .HasMaxLength(30);

                entity.Property(e => e.TenCty).HasMaxLength(100);
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaKho).HasMaxLength(20);

                entity.Property(e => e.TenKho).HasMaxLength(50);
            });

            modelBuilder.Entity<PhieuNhapXuatKho>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dvt)
                    .HasColumnName("DVT")
                    .HasMaxLength(20);

                entity.Property(e => e.Gio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.LoaiPhieu).HasMaxLength(10);

                entity.Property(e => e.LyDo).HasMaxLength(100);

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.NguoiNhan).HasMaxLength(50);

                entity.Property(e => e.TenCty).HasMaxLength(50);

                entity.Property(e => e.TongSl).HasColumnName("TongSL");

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.PhieuNhapXuatKho)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhieuNhapXuatKho_HopDong");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ban).HasMaxLength(10);

                entity.Property(e => e.ChiTiet).HasMaxLength(50);

                entity.Property(e => e.Dvt)
                    .HasColumnName("DVT")
                    .HasMaxLength(30);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.KichThuoc).HasMaxLength(10);

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.Pohv)
                    .HasColumnName("POHV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenCty).HasMaxLength(100);

                entity.Property(e => e.TongSl).HasColumnName("TongSL");

                entity.Property(e => e.ViTri).HasMaxLength(10);

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPham_HopDong");

                entity.HasOne(d => d.Kho)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.KhoId)
                    .HasConstraintName("FK_SanPham_Kho");
            });

            modelBuilder.Entity<SanPhamNhapXuatKho>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhieuId).HasColumnName("Phieu_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("SanPham_ID");

                entity.HasOne(d => d.Phieu)
                    .WithMany(p => p.SanPhamNhapXuatKho)
                    .HasForeignKey(d => d.PhieuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPhamNhapXuatKho_PhieuNhapXuatKho");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.SanPhamNhapXuatKho)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPhamNhapXuatKho_SanPham");
            });

            modelBuilder.Entity<SoLanIn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DinhMucNguyenLieuId).HasColumnName("DinhMucNguyenLieu_ID");

                entity.HasOne(d => d.DinhMucNguyenLieu)
                    .WithMany(p => p.SoLanIn)
                    .HasForeignKey(d => d.DinhMucNguyenLieuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SoLanIn_DinhMucNguyenLieu");
            });

            modelBuilder.Entity<TaiLieu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FileTaiLieu).HasMaxLength(100);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.TaiLieu)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaiLieu_HopDong");
            });

            modelBuilder.Entity<YeuCauGiaoHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaYeuCau).HasMaxLength(10);

                entity.Property(e => e.NgayDkgiaoHang)
                    .HasColumnName("NgayDKGiaoHang")
                    .HasColumnType("date");

                entity.Property(e => e.Nvpt)
                    .HasColumnName("NVPT")
                    .HasMaxLength(50);

                entity.Property(e => e.PhongBan).HasMaxLength(50);

                entity.Property(e => e.TenCty).HasMaxLength(50);

                entity.Property(e => e.TinhTrang).HasMaxLength(50);

                entity.Property(e => e.TongSldk).HasColumnName("TongSLDK");

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.YeuCauGiaoHang)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YeuCauGiaoHang_HopDong");
            });

            modelBuilder.Entity<YeuCauSx>(entity =>
            {
                entity.ToTable("YeuCauSX");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.HdId).HasColumnName("HD_ID");

                entity.Property(e => e.MaHang).HasMaxLength(20);

                entity.Property(e => e.MaVai).HasMaxLength(20);

                entity.Property(e => e.MaYeuCau).HasMaxLength(20);

                entity.Property(e => e.MauVai).HasMaxLength(20);

                entity.Property(e => e.Mua).HasMaxLength(20);

                entity.Property(e => e.NgayDkhoanThanh)
                    .HasColumnName("NgayDKHoanThanh")
                    .HasColumnType("date");

                entity.Property(e => e.Nvpt)
                    .HasColumnName("NVPT")
                    .HasMaxLength(50);

                entity.Property(e => e.PhongBan).HasMaxLength(50);

                entity.Property(e => e.SlchuaSx).HasColumnName("SLChuaSX");

                entity.Property(e => e.SldaSx).HasColumnName("SLDaSX");

                entity.Property(e => e.SlyeuCauSx).HasColumnName("SLYeuCauSX");

                entity.Property(e => e.TenCty).HasMaxLength(50);

                entity.HasOne(d => d.Hd)
                    .WithMany(p => p.YeuCauSx)
                    .HasForeignKey(d => d.HdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YeuCauSX_HopDong");
            });
        }
    }
}
