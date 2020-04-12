using MVC_Basics.Models.Entity;
using MVC_Basics.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Models.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly DB_VSEntities1 dB_VSEntities1;
        public EmployeeService()
        {
            dB_VSEntities1 = new DB_VSEntities1();
        }

        public Employee Edit(int id)
        {
            try
            {
                var emp = dB_VSEntities1.Employees.Where(e => e.ID == id).FirstOrDefault();
                return emp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            try
            {
                var result = dB_VSEntities1.Employees.Select(e => e).ToList(); // using method syntext form of linq . 
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Employee employee)
        {
            try
            {
                var emp = dB_VSEntities1.Employees.Where(e => e.ID == employee.ID).FirstOrDefault();
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Address = employee.Address;
                emp.Gender = employee.Gender;
                var res = dB_VSEntities1.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) { 
                throw ex;
            }
        }       
     }
 }
