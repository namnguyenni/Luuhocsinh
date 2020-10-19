using QLDHS.Models.Function;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDHS.Controllers
{
    public class LuuHSController : Controller
    {
        // GET: LuuHS
        public ActionResult Index()
        {
            try
            {
                F_Luuhocsinh f_lhs = new F_Luuhocsinh();
                ViewBag.alllhs = f_lhs.GetAll_LHS();
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        public ActionResult DetailLHS(string MALHS)
        {
            F_Luuhocsinh f_lhs = new F_Luuhocsinh();
            var detaillhs = f_lhs.Detai_LHS_Ma(MALHS);

            return View(detaillhs);
        }


        [HttpPost]
        public string UploadAvatar(HttpPostedFileBase AvatarImg,string id)
        {
            try
            {
                string fileExtend = System.IO.Path.GetExtension(AvatarImg.FileName);


                string targetFolder = Server.MapPath("~/Content/img/img_lhs/");
                string targetPath = Path.Combine(targetFolder, id+ fileExtend);
                AvatarImg.SaveAs(targetPath);
                F_Luuhocsinh f_lhs = new F_Luuhocsinh();
                f_lhs.ChangeImageLHS(id, "Content/img/img_lhs/"+id+ fileExtend);
                return "Upload thành công";
            }
            catch (Exception)
            {
                return "Upload không thành công";
                
            }

            
        }



    }
}