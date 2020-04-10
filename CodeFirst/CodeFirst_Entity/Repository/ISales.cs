using CodeFirst_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Entity.Repository
{
    public interface ISales
    {
        public List<Customer> Show();

        public List<Customer> ShowSingle(int id);

        //public bool NewRecord(Orders orders);

        public bool NewOrder(Orders orders);

        public bool RemoveRecord(Orders orders);
    }
}
