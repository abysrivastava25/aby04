using Employee_Model.Models.entityModels;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_App.Data.Services
{
    public class Login
    {
        private readonly DB_VSContext dB_VSContext;
        public Login(DB_VSContext _dB_VSContext)
        {
            dB_VSContext = _dB_VSContext;
        }
        public string SignIn(TblLogin login)
        {
            dB_VSContext.TblLogin.Add(login);
            dB_VSContext.SaveChanges();
            return "Done";
        }
    }
}
