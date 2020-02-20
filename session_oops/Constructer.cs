using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    class Cons
    {
        public Cons(string msg)
        {
            string str = msg;
            Console.WriteLine(str);
        }
    }
    class Derived_class:Cons
    {
        public Derived_class(string msg) : base("this is base class constructor")
        { 
        }
    }
}
