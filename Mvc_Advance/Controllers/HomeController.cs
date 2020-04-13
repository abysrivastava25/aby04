using Mvc_Advance.Models.Entity;
using Mvc_Advance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc_Advance.Controllers
{
    [HandleError(View = "_CustError")]
    public class HomeController : Controller
    {
        readonly ILogin login;

        public HomeController()
        {
            login = new Models.Services.Login();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginData()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 50)]
        public ActionResult LoginData(TBL_Login loginDetail)
        {
            if (ModelState.IsValid)
            {

                var res = login.AuthenticateCreds(loginDetail);
                if (res)
                {
                    FormsAuthentication.SetAuthCookie(loginDetail.Name, false);
                }
                return RedirectToAction("Employees");

            }
            else
            {
                return View();
            }
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Employees()
        {

            var data = login.ShowData();
            return View(data);

        }

        public ActionResult QuesFive()
        {
            return View();
        }

        public ActionResult ErrorAction()
        {
            throw new Exception("Unhandled");
        }


    }
}