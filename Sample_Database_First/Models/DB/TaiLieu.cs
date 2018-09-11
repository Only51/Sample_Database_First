using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class TaiLieu
    {
        public int Id { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public string FileTaiLieu { get; set; }
        public DateTime? NgayTao { get; set; }
        public int HdId { get; set; }

        public HopDong Hd { get; set; }
    }
}
