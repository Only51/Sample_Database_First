using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class YeuCauSx
    {
        public YeuCauSx()
        {
            KeHoachSx = new HashSet<KeHoachSx>();
        }

        public int Id { get; set; }
        public string MaYeuCau { get; set; }
        public int HdId { get; set; }
        public string TenCty { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public int? SldaSx { get; set; }
        public int? SlchuaSx { get; set; }
        public int? SlyeuCauSx { get; set; }
        public DateTime? NgayDkhoanThanh { get; set; }
        public string Nvpt { get; set; }
        public string PhongBan { get; set; }
        public string GhiChu { get; set; }

        public HopDong Hd { get; set; }
        public ICollection<KeHoachSx> KeHoachSx { get; set; }
    }
}
