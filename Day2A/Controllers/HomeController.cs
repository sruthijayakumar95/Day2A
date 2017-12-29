using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2A.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index(int id)
        //{

        //    return Content(id.ToString());
        //}

        public ActionResult Index(int id)
        {
            return Content(id.ToString());
        }
        public ActionResult Index1(int? id)
        {
            TempData["Id"] = id;
            TempData.Keep("Id");
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
      

    }
}