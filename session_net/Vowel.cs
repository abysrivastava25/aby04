using System;
using System.Collections.Generic;
using System.Text;

namespace session_net
{
    class Vowel
    {
        public void Switch_Vowel(char input)
        {
            switch (input)
            {
                case 'A':
                    Console.WriteLine("vowel");
                    break;
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("its a consonant");
                    break;
            }

        }

        public void If_else(char input)
        {
            if (input == 'A' || input == 'a' || input == 'E' || input == 'e' || input == 'I' || input == 'i' || input == 'O' || input == 'o' || input == 'U' || input == 'u')
            {
                Console.WriteLine("it is a vowel");
            }
            else
            {
                Console.WriteLine("it is a consonant");
            }

        }
    }
}
