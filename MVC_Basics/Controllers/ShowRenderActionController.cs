using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class ShowRenderActionController : Controller
    {
        // GET: ShowRenderAction
        public ActionResult Index()
        {
            return View();
        }
    }
}