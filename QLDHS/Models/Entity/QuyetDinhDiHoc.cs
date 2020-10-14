namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyetDinhDiHoc")]
    public partial class QuyetDinhDiHoc
    {
        [Key]
        public int MaQuyetDinh { get; set; }

        [Column("QuyetDinhDiHoc")]
        public string QuyetDinhDiHoc1 { get; set; }

        [StringLength(20)]
        public string MaLHS { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }
    }
}
