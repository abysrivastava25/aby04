using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst_Entity.Models;
using CodeFirst_Entity.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst_Entity.Controllers
{
    [Route("api/[controller]/{actions}")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ISales _sales;
        public MainController(ISales sales)
        {
            _sales = sales;
        }
        public IActionResult DisplayAll()
        {
            try
            {
                var data = _sales.Show();
                return Ok(data);
            }
            catch
            {
                return Ok();
            }
        }
            
        [HttpGet("{id}")]
        public IActionResult DisplaySingle(int id)
        {
            try
            {
                var res = _sales.ShowSingle(id);
                return Ok(res);
            }
            catch
            {
                return Ok();
            }
        }

       
        [HttpPost]
        public IActionResult InsertNew(Orders orders)
        {
            try
            {
                var result = _sales.NewOrder(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        [HttpPut]
        public IActionResult AddOrder(Orders orders)
        {
            try
            {
                var result = _sales.NewOrder(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpDelete]
        public IActionResult Delete(Orders orders)
        {
            try
            {
                var result = _sales.RemoveRecord(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}