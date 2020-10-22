using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using QLDHS.Models.Function;
using QLDHS.Models.Entity;
using System.Web.UI;
using ClosedXML.Excel;
using ClosedXML;
namespace QLDHS.Controllers
{
    public class BaocaoController : Controller
    {
        // GET: Baocao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Baocao_Excel_1()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Thong ke so luong luu hoc sinh");
                var current_row = 1;

                #region header
                worksheet.Cell(current_row, 1).Value = "Mã nước";
                worksheet.Cell(current_row, 2).Value = "Nước";
                worksheet.Cell(current_row, 3).Value = "Số lượng";
                #endregion


                #region thân
                foreach (var item in new F_Luuhocsinh().Thongke_LHS_time(2019))
                {
                    current_row++;
                    worksheet.Cell(current_row, 1).Value = item.madiaban;
                    worksheet.Cell(current_row, 2).Value = item.diaban;
                    worksheet.Cell(current_row, 3).Value = item.soluong;
                }
                #endregion

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ThongkeLHSCountry.xlsx");
                }
            }

        }

    }
}