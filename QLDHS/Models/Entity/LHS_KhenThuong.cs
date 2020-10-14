namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LHS_KhenThuong
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLHS { get; set; }

        public int MaKhenThuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianNhan { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }

        public virtual KhenThuong KhenThuong { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }
    }
}
