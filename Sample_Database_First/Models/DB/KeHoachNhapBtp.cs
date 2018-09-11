using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class KeHoachNhapBtp
    {
        public int Id { get; set; }
        public string MaVach { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgayDuKien { get; set; }
        public string TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public int HdId { get; set; }

        public HopDong Hd { get; set; }
    }
}
