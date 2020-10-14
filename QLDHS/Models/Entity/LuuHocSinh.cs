namespace QLDHS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuuHocSinh")]
    public partial class LuuHocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LuuHocSinh()
        {
            KetQuaHocTaps = new HashSet<KetQuaHocTap>();
            LHS_DaoTao = new HashSet<LHS_DaoTao>();
            LHS_KhenThuong = new HashSet<LHS_KhenThuong>();
            LHS_KyLuat = new HashSet<LHS_KyLuat>();
            LHS_QuanHam = new HashSet<LHS_QuanHam>();
            LHS_VePhep = new HashSet<LHS_VePhep>();
            LuanVanTotNghieps = new HashSet<LuanVanTotNghiep>();
            QuaTrinhCongTacs = new HashSet<QuaTrinhCongTac>();
            QuyetDinhDiHocs = new HashSet<QuyetDinhDiHoc>();
            ThanNhans = new HashSet<ThanNhan>();
        }

        [Key]
        [StringLength(20)]
        public string MaLHS { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(20)]
        public string SoHieuSiQuan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhapNgu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayVaoDoan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayVaoDang { get; set; }

        [StringLength(100)]
        public string DanToc { get; set; }

        [StringLength(100)]
        public string TonGiao { get; set; }

        [StringLength(100)]
        public string Mien { get; set; }

        public double? HocPhi { get; set; }

        public double? SinhHoatPhi { get; set; }

        public double? BHYT { get; set; }

        public double? ChiPhiKhac { get; set; }

        [StringLength(50)]
        public string GiaHanThoiGianDaoTao { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [StringLength(100)]
        public string QuanHam { get; set; }

        [StringLength(500)]
        public string NghienCuuNoiBat { get; set; }

        public int? MaDKP { get; set; }

        public int? MaDoiTuong { get; set; }

        public virtual DangKinhPhiDaoTao DangKinhPhiDaoTao { get; set; }

        public virtual DoiTuong DoiTuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaHocTap> KetQuaHocTaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LHS_DaoTao> LHS_DaoTao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LHS_KhenThuong> LHS_KhenThuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LHS_KyLuat> LHS_KyLuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LHS_QuanHam> LHS_QuanHam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LHS_VePhep> LHS_VePhep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuanVanTotNghiep> LuanVanTotNghieps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuaTrinhCongTac> QuaTrinhCongTacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyetDinhDiHoc> QuyetDinhDiHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanNhan> ThanNhans { get; set; }
    }
}
