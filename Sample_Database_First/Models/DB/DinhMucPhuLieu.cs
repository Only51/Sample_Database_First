using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class DinhMucPhuLieu
    {
        public int Id { get; set; }
        public string TenPl { get; set; }
        public string Dvt { get; set; }
        public double? Dmsp { get; set; }
        public int? SoKhuon { get; set; }
        public string GhiChu { get; set; }
        public int DinhMucNplId { get; set; }

        public DinhMucNpl DinhMucNpl { get; set; }
    }
}
