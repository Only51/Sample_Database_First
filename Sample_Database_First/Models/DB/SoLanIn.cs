using System;
using System.Collections.Generic;

namespace Sample_Database_First.Models.DB
{
    public partial class SoLanIn
    {
        public int Id { get; set; }
        public int DinhMucNguyenLieuId { get; set; }
        public int? SoLuongIn { get; set; }

        public DinhMucNguyenLieu DinhMucNguyenLieu { get; set; }
    }
}
