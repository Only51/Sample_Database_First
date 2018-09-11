using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class Kho
    {
        public Kho()
        {
            SanPham = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string TenKho { get; set; }
        public string MaKho { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
