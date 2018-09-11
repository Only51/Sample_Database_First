using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class DinhMucNpl
    {
        public DinhMucNpl()
        {
            DinhMucNguyenLieu = new HashSet<DinhMucNguyenLieu>();
            DinhMucPhuLieu = new HashSet<DinhMucPhuLieu>();
        }

        public int Id { get; set; }
        public string Mua { get; set; }
        public string MaHang { get; set; }
        public string MauVai { get; set; }
        public string MaVai { get; set; }
        public DateTime? NgayTao { get; set; }
        public int HdId { get; set; }

        public HopDong Hd { get; set; }
        public ICollection<DinhMucNguyenLieu> DinhMucNguyenLieu { get; set; }
        public ICollection<DinhMucPhuLieu> DinhMucPhuLieu { get; set; }
    }
}
