using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    class Ovrload
    {
        /* ------------------------------------------------------------
         * overloading with different parameters 
         * ------------------------------------------------------------
         */
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a,int b,int c)
        {
            return a + b + c;
        }

        /*------------------------------------------------------------
         * overloading on the basis of datatype 
         * -----------------------------------------------------------
         */
        public double Multi(int a,double b)
        {
            return a * b;
        }
        public double Multi(double a,int b)
        {
            return a * b;
        }

    }
}
