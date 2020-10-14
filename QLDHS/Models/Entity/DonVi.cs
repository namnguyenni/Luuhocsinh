namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonVi")]
    public partial class DonVi
    {
        [Key]
        public int MaDonVi { get; set; }

        [Column("DonVi")]
        [StringLength(100)]
        public string DonVi1 { get; set; }

        public int? MaDonViCapTren { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }
    }
}
