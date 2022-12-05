using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioUpdate.Controllers
{
    public class EducationController : Controller
    {
        [HttpGet]
        public ActionResult Education()
        {
            ViewBag.SchoolName = "SSVM";

            ViewBag.SchoolPercentage = 83;

            ViewBag.CollegeName = "SBR Women's College";

            ViewBag.Stream = "Chemical Engineering";

            ViewBag.CollegePercentage = 82;

            return View();
        }
      
    }
}