using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLDHS.Models.Function
{
    public class Reporter
    {
        //báo cáo Excel
        //bao cáo 1
        public void Baocao1_ToExcel(HttpResponseBase Response, object clientsList)
        {
            var grid = new System.Web.UI.WebControls.GridView();
            grid.DataSource = clientsList;
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=FileName.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            grid.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }

        //báo cáo 2


        //báo cáo 3


        //báo cáo Word
        //báo cáo 1



        //báo cáo 2



        //báo cáo 3



    }


}