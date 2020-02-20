using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    /*--------------------------------------------------------------------------------------------------------------------------
     *abstract class contains abstract methods and non-abstract methods.
     *abstract class shows only the data which is required for the user to see, it doesnt shows you implementation of the method.
     ----------------------------------------------------------------------------------------------------------------------------
     */
     
     
   abstract class abs_inter
    {
        public void Disp()
        {
            Console.WriteLine("this is a abstract class ");

        }
        public abstract void Display();
    }
    /*--------------------------------------------------------------------------------------------------------------
     * interface contains only the abstract method and doesnt contains the non-abstract methods.
     * interface contains only the declaration of the method and it doesnt contains the implementation of the method.
     * by default all the methods of interface are public.
     * interface cannot be instantiated. Interface can only be inherited. 
     * -------------------------------------------------------------------------------------------------------------
     */
    interface Demo
    {
        void show();
        
    }
}
