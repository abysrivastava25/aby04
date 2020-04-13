using Mvc_Advance.Models.Entity;
using Mvc_Advance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Advance.Models.Services
{
    public class Login : ILogin
    {
        public bool AuthenticateCreds(TBL_Login loginDetail)
        {
            try
            {
                DB_VSEntities1 conn = new DB_VSEntities1();
                var name = conn.TBL_Login.Where(x => x.Name == loginDetail.Name).Select(x => x.Name).ToList();
                var password = conn.TBL_Login.Where(x => x.Password == loginDetail.Password).Select(x => x.Password).ToList();
                if (loginDetail.Name == name.FirstOrDefault() && loginDetail.Password == password.FirstOrDefault())
                {

                    return true; ;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee Detail(int id)
        {
            try
            {

                var context = new DB_VSEntities1();
                var data = context.Employees.Where(x => x.ID == id).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Employee> Show()
        {
            try
            {
                DB_VSEntities1 conn = new DB_VSEntities1();
                var data = conn.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> ShowData()
        {
            try
            {
                DB_VSEntities1 conn = new DB_VSEntities1();
                var data = conn.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}