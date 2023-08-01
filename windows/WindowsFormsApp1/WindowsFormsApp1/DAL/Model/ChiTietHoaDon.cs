namespace WindowsFormsApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int idChiTiet { get; set; }

        public int idHoaDon { get; set; }

        public int TenGhe { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
