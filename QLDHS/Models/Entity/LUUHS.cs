namespace QLDHS.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LUUHS : DbContext
    {
        public LUUHS()
            : base("name=LUUHS")
        {
        }

        public virtual DbSet<BacDaoTao> BacDaoTaos { get; set; }
        public virtual DbSet<ChiTietDaoTao> ChiTietDaoTaos { get; set; }
        public virtual DbSet<ChuyenNganhDaoTao> ChuyenNganhDaoTaos { get; set; }
        public virtual DbSet<CoSoDaoTao> CoSoDaoTaos { get; set; }
        public virtual DbSet<DangKinhPhiDaoTao> DangKinhPhiDaoTaos { get; set; }
        public virtual DbSet<DiaBanDaoTao> DiaBanDaoTaos { get; set; }
        public virtual DbSet<DoiTuong> DoiTuongs { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }
        public virtual DbSet<KetQuaHocTap> KetQuaHocTaps { get; set; }
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<LHS_DaoTao> LHS_DaoTao { get; set; }
        public virtual DbSet<LHS_KhenThuong> LHS_KhenThuong { get; set; }
        public virtual DbSet<LHS_KyLuat> LHS_KyLuat { get; set; }
        public virtual DbSet<LHS_QuanHam> LHS_QuanHam { get; set; }
        public virtual DbSet<LHS_VePhep> LHS_VePhep { get; set; }
        public virtual DbSet<LuanVanTotNghiep> LuanVanTotNghieps { get; set; }
        public virtual DbSet<LuuHocSinh> LuuHocSinhs { get; set; }
        public virtual DbSet<NganhDaoTao> NganhDaoTaos { get; set; }
        public virtual DbSet<QuanHam> QuanHams { get; set; }
        public virtual DbSet<QuaTrinhCongTac> QuaTrinhCongTacs { get; set; }
        public virtual DbSet<QuyetDinhDiHoc> QuyetDinhDiHocs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ThanNhan> ThanNhans { get; set; }
        public virtual DbSet<UserName> UserNames { get; set; }
        public virtual DbSet<VePhep> VePheps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacDaoTao>()
                .Property(e => e.BacDaoTao1)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietDaoTao>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenNganhDaoTao>()
                .HasMany(e => e.LHS_DaoTao)
                .WithOptional(e => e.ChuyenNganhDaoTao)
                .HasForeignKey(e => e.MaCNDaoTao1);

            modelBuilder.Entity<ChuyenNganhDaoTao>()
                .HasMany(e => e.LHS_DaoTao1)
                .WithOptional(e => e.ChuyenNganhDaoTao1)
                .HasForeignKey(e => e.MaCNDaoTao2);

            modelBuilder.Entity<CoSoDaoTao>()
                .HasMany(e => e.LHS_DaoTao)
                .WithRequired(e => e.CoSoDaoTao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaBanDaoTao>()
                .Property(e => e.MaDiaBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KetQuaHocTap>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhenThuong>()
                .HasMany(e => e.LHS_KhenThuong)
                .WithRequired(e => e.KhenThuong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KyLuat>()
                .HasMany(e => e.LHS_KyLuat)
                .WithRequired(e => e.KyLuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LHS_DaoTao>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LHS_DaoTao>()
                .Property(e => e.ThoiGianKetThuc)
                .IsFixedLength();

            modelBuilder.Entity<LHS_DaoTao>()
                .HasMany(e => e.ChiTietDaoTaos)
                .WithOptional(e => e.LHS_DaoTao)
                .HasForeignKey(e => e.MaLHS_DaoTao);

            modelBuilder.Entity<LHS_KhenThuong>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LHS_KyLuat>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LHS_QuanHam>()
                .Property(e => e.MaLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LHS_VePhep>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LuanVanTotNghiep>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LuuHocSinh>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LuuHocSinh>()
                .Property(e => e.SoHieuSiQuan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LuuHocSinh>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.LHS_DaoTao)
                .WithRequired(e => e.LuuHocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.LHS_KhenThuong)
                .WithRequired(e => e.LuuHocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.LHS_KyLuat)
                .WithRequired(e => e.LuuHocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.LHS_QuanHam)
                .WithRequired(e => e.LuuHocSinh)
                .HasForeignKey(e => e.MaLSH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.LHS_VePhep)
                .WithRequired(e => e.LuuHocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuuHocSinh>()
                .HasMany(e => e.QuaTrinhCongTacs)
                .WithRequired(e => e.LuuHocSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuanHam>()
                .HasMany(e => e.LHS_QuanHam)
                .WithRequired(e => e.QuanHam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuaTrinhCongTac>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuyetDinhDiHoc>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.CanBo)
                .IsFixedLength();

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.MaLHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VePhep>()
                .HasMany(e => e.LHS_VePhep)
                .WithRequired(e => e.VePhep)
                .WillCascadeOnDelete(false);
        }
    }
}
