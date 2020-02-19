using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Leap_Year
    {
        //for evaluating the year to be a leap year.
        public void Leap_yr(int days)
        {
            if (days % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
