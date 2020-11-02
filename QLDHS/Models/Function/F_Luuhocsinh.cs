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


        List<InforLHS> allInfoLHS = new LUUHS().Database.SqlQuery<InforLHS>("exec dbo.getAll_LHS").ToList();

        /// <summary>
        /// Lấy danh sách tất cả lưu học sinh
        /// </summary>
        /// <returns></returns>
        public List<InforLHS> GetAll_LHS()
        {                         
            return allInfoLHS;
        }

        public InforLHS Detai_LHS_Ma(string malhs)
        {           
            foreach (var item in allInfoLHS)
            {
                if (item.MaLHS == null)
                {
                    continue;
                }
                if (item.MaLHS.TrimEnd() == malhs)
                {
                    return item;
                }
            }


            return null;



        }

        public List<Thongke_lhs_time_class> Thongke_LHS_time(int year)
        {
            LUUHS lhs = new LUUHS();
            SqlParameter endDate = new SqlParameter("@date", year);
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

        public bool AddNewLHS(LuuHocSinh lhs)
        {
            using (LUUHS luuhs = new LUUHS())
            {
                try
                {                    
                    luuhs.LuuHocSinhs.Add(lhs);
                    luuhs.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }             
            }
        }

    }
}