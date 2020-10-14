namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDaoTao")]
    public partial class ChiTietDaoTao
    {
        public int ID { get; set; }

        public int? MaLHS_DaoTao { get; set; }

        [StringLength(20)]
        public string MaLHS { get; set; }

        public int? MaBacDaoTao { get; set; }

        public virtual BacDaoTao BacDaoTao { get; set; }

        public virtual LHS_DaoTao LHS_DaoTao { get; set; }
    }
}
