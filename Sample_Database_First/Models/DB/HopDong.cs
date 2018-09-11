using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class HopDong
    {
        public HopDong()
        {
            ChiTietDatHang = new HashSet<ChiTietDatHang>();
            DinhMucNpl = new HashSet<DinhMucNpl>();
            KeHoachNhapBtp = new HashSet<KeHoachNhapBtp>();
            KeHoachSx = new HashSet<KeHoachSx>();
            KetTest = new HashSet<KetTest>();
            PhieuNhapXuatKho = new HashSet<PhieuNhapXuatKho>();
            SanPham = new HashSet<SanPham>();
            TaiLieu = new HashSet<TaiLieu>();
            YeuCauGiaoHang = new HashSet<YeuCauGiaoHang>();
            YeuCauSx = new HashSet<YeuCauSx>();
        }

        public int Id { get; set; }
        public string MaHd { get; set; }
        public int? KhId { get; set; }
        public DateTime? NgayKi { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal? TyGia { get; set; }
        public string NganHang { get; set; }
        public decimal? TongTien { get; set; }
        public string NguoiLienHe { get; set; }
        public string ChucDanh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string NhanVien { get; set; }
        public string GhiChu { get; set; }

        public KhachHang Kh { get; set; }
        public ICollection<ChiTietDatHang> ChiTietDatHang { get; set; }
        public ICollection<DinhMucNpl> DinhMucNpl { get; set; }
        public ICollection<KeHoachNhapBtp> KeHoachNhapBtp { get; set; }
        public ICollection<KeHoachSx> KeHoachSx { get; set; }
        public ICollection<KetTest> KetTest { get; set; }
        public ICollection<PhieuNhapXuatKho> PhieuNhapXuatKho { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
        public ICollection<TaiLieu> TaiLieu { get; set; }
        public ICollection<YeuCauGiaoHang> YeuCauGiaoHang { get; set; }
        public ICollection<YeuCauSx> YeuCauSx { get; set; }
    }
}
