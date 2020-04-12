using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class RenderSectionController : Controller
    {
        // GET: RenderSection
        public ActionResult Index()
        {
            return View();
        }
    }
}