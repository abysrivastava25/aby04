using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using token.Models.entityModels;
using token.Repository;

namespace token.Services
{
    public class StudentInformation : IStudentInformation
    {
        public List<Login> GetData()
        {

            try
            {
                var context = new TokenDBContext();
                var data = (from l in context.Login
                            select l).ToList();
                return data;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Login> GetUData()
        {
            try
            {
                var context = new TokenDBContext();
                var info = (from l in context.Login
                            where l.Role == "User"
                            select l).ToList();
                return info;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
