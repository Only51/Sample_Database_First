using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class DinhMucNguyenLieu
    {
        public DinhMucNguyenLieu()
        {
            SoLanIn = new HashSet<SoLanIn>();
        }

        public int Id { get; set; }
        public string TenNl { get; set; }
        public string MauVai { get; set; }
        public string MauMuc { get; set; }
        public string Dvt { get; set; }
        public double? DinhMuc { get; set; }
        public int? SldonHang { get; set; }
        public string ViTriIn { get; set; }
        public int DinhMucNplId { get; set; }

        public DinhMucNpl DinhMucNpl { get; set; }
        public ICollection<SoLanIn> SoLanIn { get; set; }
    }
}
