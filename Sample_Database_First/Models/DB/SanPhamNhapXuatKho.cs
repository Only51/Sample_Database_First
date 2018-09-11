using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class SanPhamNhapXuatKho
    {
        public int Id { get; set; }
        public int PhieuId { get; set; }
        public int SanPhamId { get; set; }

        public PhieuNhapXuatKho Phieu { get; set; }
        public SanPham SanPham { get; set; }
    }
}
