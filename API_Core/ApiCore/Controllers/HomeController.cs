using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiCore.Models;
using ApiCore.Data;
using System.Data;

namespace ApiCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Iemployee _employees;

        public HomeController(Iemployee employee)
        {
            _employees = employee;
        }
        public IActionResult Show()
        {
            DataSet ds = _employees.ShowData();
            return Ok(ds);
        }

        [HttpPost]
        public ActionResult<bool> Insert(Employee empInsert)
        {
            var result = _employees.Insert(empInsert);
            return Ok(result);
        }

        //using overloaded HttpGet which accepts an ID from URL
        [HttpGet("{id}")]
        public IActionResult ShowSingle(int ID)
        {
            DataSet dataSet = _employees.ShowSingle(ID);
            return Ok(dataSet);
        }

        [HttpPut]
        public bool Update(Employee empUpdate)
        {
            var updated = _employees.Update(empUpdate);
            return updated;
        }

        [HttpDelete]
        public bool Delete(Employee empDelete)
        {
            var deleted = _employees.Delete(empDelete);
            return deleted;
        }

    }
}