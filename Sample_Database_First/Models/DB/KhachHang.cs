using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HopDong = new HashSet<HopDong>();
        }

        public int Id { get; set; }
        public string MaKh { get; set; }
        public string TenCty { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string MaSoThue { get; set; }
        public string Email { get; set; }
        public string NvphuTrach { get; set; }
        public string GhiChu { get; set; }

        public ICollection<HopDong> HopDong { get; set; }
    }
}
