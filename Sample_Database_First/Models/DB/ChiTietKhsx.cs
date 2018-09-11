using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class ChiTietKhsx
    {
        public int Id { get; set; }
        public string Chuyen { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? SoLuong { get; set; }
        public int? NangXuatDuKien { get; set; }
        public string GhiChu { get; set; }
        public int? KeHoachId { get; set; }

        public KeHoachSx KeHoach { get; set; }
    }
}
