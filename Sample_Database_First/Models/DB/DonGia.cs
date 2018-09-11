using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class DonGia
    {
        public int Id { get; set; }
        public int ChiTietDatHangId { get; set; }
        public string TenDonGia { get; set; }
        public double? DonGia1 { get; set; }

        public ChiTietDatHang ChiTietDatHang { get; set; }
    }
}
