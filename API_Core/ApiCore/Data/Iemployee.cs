using ApiCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Data
{
    public interface Iemployee
    {
        DataSet ShowData();
        bool Insert(Employee emp1);
        DataSet ShowSingle(int ID);
        bool Update(Employee empData);
        bool Delete(Employee empDel);
    }
}
