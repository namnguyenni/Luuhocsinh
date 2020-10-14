using QLDHS.Models.Function;
using System;
using System.Collections.Generic;
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


        
    }
}