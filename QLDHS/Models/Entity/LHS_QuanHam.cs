namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LHS_QuanHam
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaLSH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaQuanHam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }

        public virtual QuanHam QuanHam { get; set; }
    }
}
