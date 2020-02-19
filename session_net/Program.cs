using System;

namespace session_net
{
    class Static_Instance
    {

        static int a = 5;
        int b = 6;
        static void Main(string[] args)
        {
            Static_Instance obj = new Static_Instance();
            Console.WriteLine("Static variable" + a);
            Console.WriteLine("Instance variable" + obj.b);

            //leap year program
            Leap_Year obj1 = new Leap_Year();
            //method calling leap year
            obj1.Leap_yr(365);
           
            Vowel obj2 = new Vowel();
            //vowel program


            //switch case method calling
            obj2.Switch_Vowel('A');
           
            //if_else case method calling
            obj2.If_else('i');
            

            //boxing_unboxing program
            Boxing_unBoxing ob = new Boxing_unBoxing();  //object creation
           
            ob.Boxing_Unboxing();// method calling

            //reverse string program
            Reverse_String x = new Reverse_String(); //object creation

            x.Reverse_string("abhishek");
            
            
            //multiplication program

            Muliplication ms = new Muliplication();
            ms.Multi();

            //access modifiers program
            Other_Modifiers mo = new Other_Modifiers(); //object creation 
            
            // method calling 
            mo.Private_Access();
            mo.Drived();

            Console.ReadLine();


        }
    }
}
