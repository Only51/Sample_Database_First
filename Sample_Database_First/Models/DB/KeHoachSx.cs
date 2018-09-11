using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class KeHoachSx
    {
        public KeHoachSx()
        {
            ChiTietKhsx = new HashSet<ChiTietKhsx>();
        }

        public int Id { get; set; }
        public int YeuCauId { get; set; }
        public int HdId { get; set; }
        public string TenCty { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public int? SldaSx { get; set; }
        public int? SlchuaSx { get; set; }
        public int? SlyeuCauSx { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string GhiChu { get; set; }

        public HopDong Hd { get; set; }
        public YeuCauSx YeuCau { get; set; }
        public ICollection<ChiTietKhsx> ChiTietKhsx { get; set; }
    }
}
