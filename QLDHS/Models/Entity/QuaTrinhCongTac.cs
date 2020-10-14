namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuaTrinhCongTac")]
    public partial class QuaTrinhCongTac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaQuaTrinh { get; set; }

        [Column("QuaTrinhCongTac")]
        [StringLength(500)]
        public string QuaTrinhCongTac1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLHS { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }
    }
}
