using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using WebApi_session.Data;
using WebApi_session.Models;
namespace WebApi_session.Controllers
{
    public class WebApi_Controller : ApiController
    {
        Data.Employee emp = new Data.Employee();
        [HttpGet]
        public IHttpActionResult ShowData()
        {
            DataSet ds = emp.ShowData();
            return Ok(ds);

        }
        [HttpPost]
        public bool Insert_Data(mEmployee employee)
        {
            var result = emp.Insert_Data(employee);
            return result;
        }
        [HttpPut]
        public bool Update_Data( mEmployee employee)
        {
            var res = emp.Update_Data( employee);
            return true;
        }
        [HttpDelete]
        public bool Delete_Data(mEmployee employee)
        {
            var deleted = emp.Delete_Data(employee);
            return deleted;
        }

    }
}