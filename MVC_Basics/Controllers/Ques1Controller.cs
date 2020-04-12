using MVC_Basics.Models.Entity;
using MVC_Basics.Models.Interfaces;
using MVC_Basics.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class Ques1Controller : Controller
    {
        private readonly EmployeeService employee;
        public Ques1Controller()
        {
            employee = new EmployeeService();
        }
        // GET: Ques1

        public ActionResult Index()
        {
            try
            {
                var res =GetDetails();
                return View(res);
            }
            catch
            {
                throw;
            }
        }
        
        [NonAction]
        public IEnumerable<Employee> GetDetails()
        {
            try
                {
                var res = employee.GetEmployees();
                return res;
                }
            catch
                {
                throw; 
                }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var res = employee.Edit(id);

            return View(res);
         }
        [HttpPost]
        public ActionResult Edit([Bind(Include ="FirstName,LastName,Address,Gender")]Employee emp)
        {
            var res=employee.Update(emp);
            return RedirectToAction("Index");
        }
        public ActionResult RenderAction()
        {
            return PartialView("ShowPartial_RenderAction");
        }
        [ChildActionOnly]
        public ActionResult Child()
        {
            DB_VSEntities1 dB_VSEntities1 = new DB_VSEntities1();
            var result = dB_VSEntities1.Employees;
            return View(result);
        }

        [HttpGet]
        public ActionResult CallChild()
        {
            return View();   
        }
        
    }
}