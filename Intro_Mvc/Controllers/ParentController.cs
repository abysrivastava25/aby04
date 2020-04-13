using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_Mvc.Controllers
{
    public class ParentController : Controller
    {
        // GET: Parent
        public ActionResult Index()
        {
            TempData["text"] = "the text is passed between controller to controller";
            return new RedirectResult(@"~\Child\");
            
        }
    }
}