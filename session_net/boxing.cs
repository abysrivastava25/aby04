using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Boxing_unBoxing
    {
        public void Boxing_Unboxing()
        {
            int a = 5;
            //implicit boxing or typecasting 
            object ob = a;
            Console.WriteLine("boxing result \n" + ob);
            //explicit unboxing or typecasting
            a = (int)ob;
            Console.WriteLine("unboxed result \n" + a);

        }
    }
}
