using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    class Ovr_der
    {
        public virtual void Methd()
        {
            Console.WriteLine("message from parent class ");
        }
    }
    class Over_der1:Ovr_der
    {
        public sealed override void Methd()
        {
            Console.WriteLine("message from derived class");
                
        }
    }
    
    /* this will give you a error as you are trying to override a sealed method
     * class Test : Over_der1
    {
       
            public override void methd()
                {

                }   
       
     }
     */
       

    
}
