using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_Mvc.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            var Students = new List<string>
            {
                "Vijay Kumar",
                "Vishesh Kapoor",
                "Mohd Azeem"
            };
            ViewBag.students = Students;
            return View();
        }
    }
}