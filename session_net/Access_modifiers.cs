using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Access_modifiers
    {
        private int a = 4;
        protected int b = 5;
        public int c = 6;
        internal int d = 7;
        protected internal int e = 8;

        public void Private_Access()
        {
            Console.WriteLine("private member" + a);

        }
    }
    class Other_Modifiers:Access_modifiers
    {
        public void Drived()
        {
            Console.WriteLine("protected member" + b);
            Console.WriteLine("Public member" + c);
            Console.WriteLine("internal member" + d);
            Console.WriteLine("protected internal" + e);

        }
    }
}
