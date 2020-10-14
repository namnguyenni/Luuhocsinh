namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuanVanTotNghiep")]
    public partial class LuanVanTotNghiep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLuanVan { get; set; }

        [StringLength(50)]
        public string TenLuanVan { get; set; }

        [StringLength(50)]
        public string KetQuaBaoVe { get; set; }

        [StringLength(20)]
        public string MaLHS { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }
    }
}
