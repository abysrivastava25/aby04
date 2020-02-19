using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Reverse_String
    {
        public void Reverse_string(String str)
        {
            char[] ch= str.ToCharArray();
         
            int n= ch.Length;
            char[] ch1 = new char[n];
            int i = n - 1;
            int j=0;
            while(i>=0)
            {
                ch1[j] = ch[i];
                i--;
                j++;

            }
            ch1.ToString();
            Console.WriteLine(ch1);
                
            
                
                
                
            
           
        }
    }
}
