using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    class Virtual
    {
        public virtual void _virtual()
        {
            Console.WriteLine("this message is from virtual method");

        }
    }
    class Virt:Virtual
    {
        public override void _virtual()
        {
            base._virtual();
            Console.WriteLine("this mesage is from the overriden virtual method");
        }
    }
}
