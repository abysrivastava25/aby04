using Employee_Model.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_App.Data.Services
{
    public class SideNav
    {
        private readonly DB_VSContext dB_VSContext;
        public SideNav(DB_VSContext _db_VSContext)
        {
            dB_VSContext = _db_VSContext;
        }
        public List<SideNavbar> GetSideNav()
        {
            var result = dB_VSContext.SideNavbar.ToList();

            return result;
        }
        public string AddNavBar(SideNavbar nav)
        {
            if (dB_VSContext.SideNavbar.Any(x => x.Name == nav.Name))
            {
                return "Can't generate the link with same Name";
            }
            else
            {
                dB_VSContext.SideNavbar.Add(nav);
                dB_VSContext.SaveChanges();
                return "Done";

            }


        }
    }
}
