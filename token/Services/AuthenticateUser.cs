using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using token.Models.entityModels;
using token.Repository;

namespace token.Services
{
    public class AuthenticateUser : IAuthenticateUser
    {
        public UserModel AuthenticateCreds(LoginModel login)
        {
            UserModel user = null;

            try
            {
                var context = new Models.entityModels.TokenDBContext();
                var name = (from l in context.Login
                            where l.UserName == login.Username
                            select l.UserName).ToList();
                var pass = (from l in context.Login
                            where l.Pass == login.Password
                            select l.Pass).ToList();
                var role = (from l in context.Login
                            where l.UserName == login.Username
                            select l.Role).ToList();

                if (login.Username == name.FirstOrDefault() && login.Password == pass.FirstOrDefault())
                {
                    user = new UserModel { Name = name.FirstOrDefault(), userRoles = role.FirstOrDefault() };
                }

                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
