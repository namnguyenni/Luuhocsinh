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
    public class F_Luuhocsinh
    {




        /// <summary>
        /// Lấy danh sách tất cả lưu học sinh
        /// </summary>
        /// <returns></returns>
        public List<LuuHocSinh> GetAll_LHS()
        {
            LUUHS lhs = new LUUHS();
            return lhs.LuuHocSinhs.ToList();
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
            SqlParameter endDate = new SqlParameter("@date", year);
            endDate.SqlDbType = SqlDbType.Int;
            return lhs.Database.SqlQuery<Thongke_lhs_time_class>("exec dbo.ThongKe_LHS_ThoiGian @date",  endDate).ToList();
            
        }

    }
}