namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKinhPhiDaoTao")]
    public partial class DangKinhPhiDaoTao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DangKinhPhiDaoTao()
        {
            LuuHocSinhs = new HashSet<LuuHocSinh>();
        }

        [Key]
        public int MaDKP { get; set; }

        [StringLength(50)]
        public string DangKinhPhi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuuHocSinh> LuuHocSinhs { get; set; }
    }
}
