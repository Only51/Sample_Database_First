using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamNhapXuatKho = new HashSet<SanPhamNhapXuatKho>();
        }

        public int Id { get; set; }
        public int HdId { get; set; }
        public string TenCty { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public string KichThuoc { get; set; }
        public string Dvt { get; set; }
        public int? TongSl { get; set; }
        public string ChiTiet { get; set; }
        public string Pohv { get; set; }
        public string Ban { get; set; }
        public string ViTri { get; set; }
        public int? KhoId { get; set; }

        public HopDong Hd { get; set; }
        public Kho Kho { get; set; }
        public ICollection<SanPhamNhapXuatKho> SanPhamNhapXuatKho { get; set; }
    }
}
