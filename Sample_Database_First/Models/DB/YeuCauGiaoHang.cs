using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class YeuCauGiaoHang
    {
        public int Id { get; set; }
        public string MaYeuCau { get; set; }
        public int HdId { get; set; }
        public string TenCty { get; set; }
        public DateTime? NgayDkgiaoHang { get; set; }
        public int? TongSldk { get; set; }
        public string Nvpt { get; set; }
        public string PhongBan { get; set; }
        public string TinhTrang { get; set; }
        public string GhiChu { get; set; }

        public HopDong Hd { get; set; }
    }
}
