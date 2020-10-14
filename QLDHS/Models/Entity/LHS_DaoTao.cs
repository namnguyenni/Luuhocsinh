namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LHS_DaoTao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LHS_DaoTao()
        {
            ChiTietDaoTaos = new HashSet<ChiTietDaoTao>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLHS { get; set; }

        public int MaCSDaoTao { get; set; }

        public int? MaCNDaoTao1 { get; set; }

        public int? MaCNDaoTao2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianBatDau { get; set; }

        [StringLength(10)]
        public string ThoiGianKetThuc { get; set; }

        [StringLength(10)]
        public string ThoiGianDaoTao { get; set; }

        public int? TinhTrangTotNghiep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDaoTao> ChiTietDaoTaos { get; set; }

        public virtual ChuyenNganhDaoTao ChuyenNganhDaoTao { get; set; }

        public virtual ChuyenNganhDaoTao ChuyenNganhDaoTao1 { get; set; }

        public virtual CoSoDaoTao CoSoDaoTao { get; set; }

        public virtual LuuHocSinh LuuHocSinh { get; set; }
    }
}
