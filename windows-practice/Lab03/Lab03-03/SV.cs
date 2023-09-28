namespace Lab03_03
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SV")]
    public partial class SV
    {
        [Key]
        [StringLength(50)]
        public string MaSV { get; set; }

        [StringLength(250)]
        public string TenSV { get; set; }

        [StringLength(100)]
        public string Khoa { get; set; }

        public double? DiemTB { get; set; }
    }
}
