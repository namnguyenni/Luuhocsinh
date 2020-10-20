using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLDHS.Models.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data;

namespace QLDHS.Models.Function
{
    public class Thongke_lhs_time_class
    {
        public string madiaban { get; set; }
        public string diaban { get; set; }
        public int soluong { get; set; }

       
    }

    public class AllInforLHS
    {
        public string Hoten { get; set; }
        public string MaLHS { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ThongTinLienLac { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string SoHieuSiQuan { get; set; }
        public string NgayNhapNgu { get; set; }
        public string NgayVaoDoan { get; set; }
        public string NgayVaoDang { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string Mien { get; set; }
        public string HocPhi { get; set; }
        public string SinhHoatPhi { get; set; }
        public string BHYT { get; set; }
        public string ChiPhiKhac { get; set; }
        public string GiaHanThoiGianDaoTao { get; set; }
        public string Image { get; set; }
        public string QuanHam { get; set; }
        public string NghienCuuNoiBat { get; set; }
        public string MaDVBM { get; set; }
        public string MaDVBQP { get; set; }
        public string CSDaoTao { get; set; }
        public string DiaBan { get; set; }
        public string MaKetQua { get; set; }
        public string Ki1 { get; set; }
        public string Ki2 { get; set; }
        public string Ki3 { get; set; }
        public string Ki4 { get; set; }
        public string Ki5 { get; set; }
        public string Ki6 { get; set; }
        public string Ki7 { get; set; }
        public string Ki8 { get; set; }
        public string Ki9 { get; set; }
        public string Ki10 { get; set; }
        public string Ki11 { get; set; }
        public string Ki12 { get; set; }
        public string Ki13 { get; set; }
        public string Ki14 { get; set; }
        public string PhanLoaiTotNghiep { get; set; }
        public string DiemTrungBinh { get; set; }
        public string MoTaKetQua { get; set; }
        public string LuuNoMon { get; set; }
        public string LHSID { get; set; }
        public string MaCNDaotao1 { get; set; }
        public string MaCNDaotao2 { get; set; }
        public string BoMon { get; set; }
        public string MaDVCapTren { get; set; }
        public string Khoa { get; set; }
        public string DonViBQP { get; set; }
        public string CNDT1 { get; set; }
        public string MN1 { get; set; }
        public string CNDT2 { get; set; }
        public string MN2 { get; set; }
        public string QuaTrinhCongTac { get; set; }
        public string TenLuanVan { get; set; }
        public string KetQuaBaoVe { get; set; }
        public string QuyetDinhDuHoc { get; set; }
        public string NganhDT1 { get; set; }
        public string NganhDT2 { get; set; }
        public string KiLuat { get; set; }
        public string KhenThuong { get; set; }

    }


    public class F_Luuhocsinh
    {

    


        /// <summary>
        /// Lấy danh sách tất cả lưu học sinh
        /// </summary>
        /// <returns></returns>
        public List<InforLHS> GetAll_LHS()
        {
            LUUHS lhs = new LUUHS();                        
            return lhs.Database.SqlQuery<InforLHS>("exec dbo.getAll_LHS").ToList();
        }

        public LuuHocSinh Detai_LHS_Ma(string malhs)
        {
            LUUHS lhs = new LUUHS();

            LuuHocSinh Detail = lhs.LuuHocSinhs.Where(x => x.MaLHS == malhs).FirstOrDefault();



            return Detail;
        }

        public List<Thongke_lhs_time_class> Thongke_LHS_time(int year)
        {
            LUUHS lhs = new LUUHS();
            SqlParameter endDate = new SqlParameter("@date", 2015);
            endDate.SqlDbType = SqlDbType.Int;
            return lhs.Database.SqlQuery<Thongke_lhs_time_class>("exec dbo.ThongKe_LHS_ThoiGian @date",  endDate).ToList();
            
        }

        public bool ChangeImageLHS(string id,string image)
        {
            using (var db = new LUUHS())
            {
                var result = db.LuuHocSinhs.SingleOrDefault(b => b.MaLHS == id);
                if (result != null)
                {
                    result.Image = image;
                    db.SaveChanges();
                }
            }
            return true;
        }

    }
}