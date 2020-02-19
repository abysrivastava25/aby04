using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Muliplication
    {
        public void Multi()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);

                }
                Console.WriteLine("\n");
            }
        }
    }
}
