using Intro_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel Emp)
        {
            int EmpId = Emp.ID;
            string name = Emp.Name;
            string gender = Emp.Gender;
            string city = Emp.City;

            return View();
        }
    }
}