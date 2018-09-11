using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class PhieuNhapXuatKho
    {
        public PhieuNhapXuatKho()
        {
            SanPhamNhapXuatKho = new HashSet<SanPhamNhapXuatKho>();
        }

        public int Id { get; set; }
        public int HdId { get; set; }
        public string TenCty { get; set; }
        public DateTime? Ngay { get; set; }
        public string Gio { get; set; }
        public string Dvt { get; set; }
        public int? TongSl { get; set; }
        public string LyDo { get; set; }
        public string NguoiNhan { get; set; }
        public string LoaiPhieu { get; set; }
        public int? KhoId { get; set; }

        public HopDong Hd { get; set; }
        public ICollection<SanPhamNhapXuatKho> SanPhamNhapXuatKho { get; set; }
    }
}
