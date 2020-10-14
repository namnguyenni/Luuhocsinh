namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacDaoTao")]
    public partial class BacDaoTao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacDaoTao()
        {
            ChiTietDaoTaos = new HashSet<ChiTietDaoTao>();
        }

        [Key]
        public int MaBacDaoTao { get; set; }

        [Column("BacDaoTao")]
        [StringLength(10)]
        public string BacDaoTao1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDaoTao> ChiTietDaoTaos { get; set; }
    }
}
