using MVC_Basics.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC_Basics.Models.Interfaces
{
    interface IEmployee
    {
        IEnumerable<Employee> GetEmployees();
        Employee Edit(int id);
        bool Update(Employee employee);
    }
}
