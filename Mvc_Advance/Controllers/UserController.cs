using Mvc_Advance.Models;
using Mvc_Advance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Advance.Controllers
{
    [CustomException]
    [RoutePrefix("User")]
    public class UserController : Controller
    {
        // GET: User
        readonly ILogin login;
        public UserController()
        {
            login = new Models.Services.Login();
        }
        public ActionResult Index()
        {

            var data = login.Show();
            return View(data);
        }

        [Route("{id}/Details")]
        [Route("{id}")]

        public ActionResult Details(int id)
        {

            var detail = login.Detail(id);
            return View(detail);

        }
        [FilterA(Order = 2)]
        [FilterB(Order = 1)]
        [Route("Action")]
        public ActionResult Action()
        {
            return View();
        }

    }
}