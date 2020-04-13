using Mvc_Advance.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Advance.Models.Repository
{
    interface ILogin
    {
        bool AuthenticateCreds(TBL_Login loginDetail);
        List<Employee> ShowData();

        List<Employee> Show();
        Employee Detail(int id);
    }
}
