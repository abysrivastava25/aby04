using System;

namespace session_oops
{
    class Program:abs_inter, Demo, Interface1 ,Interface2
    {
       public void Show1() //this is the immplimentation of method having conflicting name
        {
            Console.WriteLine("it is the conflictiing method having conflicting method name");
        }
        public int Add(int a,int b)//method overloading 
        {
            return a + b;
            
        }
        public int Add(int a,int b,int c)// method overloaded with three parameter 
        {
            return a + b + c;
        }
        public override void Display()//abstract methods implementation and a example of method overriding 
        {
            Console.WriteLine("this is a abstract method ");

        }
        public void show()// interface methods implementation
        {
            Console.WriteLine("this is a interface method");
        }
        
        

        
        static void Main(string[] args)
        {
            Program obj = new Program();//object creation
            /*-------------------------------------------------------
             * 1. Difference between abstraction and interface
             * ------------------------------------------------------
             */
             obj.Display();
             obj.show();
            /* ------------------------------------------------------
             * 2. Method overloading and overriding 
             * ------------------------------------------------------
             */
             
             int x = obj.Add(4, 5);
             int y = obj.Add(4, 5, 6);
             Console.WriteLine("this is two parameter methods result  " + x);
             Console.WriteLine("this is three parameter result  " + y);
             /* -----------------------------------------------------
              * 3. interface having methods with conflicting name
              * -----------------------------------------------------
              */
              obj.Show1();
            /* ----------------------------------------------------
             * 4. different ways a method can be overloaded
             * ----------------------------------------------------
             */
             Ovrload ovr = new Ovrload();
            Console.WriteLine("overloaded method having two parameters  " + ovr.Addition(5, 7));
            Console.WriteLine("overloaded method having three parameters " + ovr.Addition(5, 7, 9));
            Console.WriteLine("overloaded methof having different data types  " + ovr.Multi(2.2d, 5));
            Console.WriteLine("overloaded method having different data types  " + ovr.Multi(7, 3.6d));
            /*------------------------------------------------------------------------------------------
             * 5. virtual methods are the methods which have the implementation in both the parent as well
             *    as the derived class. Virtual methods are required when there is some functionaliy in 
             *    the parent class but more functionality is needed in the derived class.
             *-------------------------------------------------------------------------------------------
             */
            Virt vir = new Virt();
            vir._virtual();

            /*-------------------------------------------------------------------------------------------
             * 7.  Calling base class constructor from derived class  
             *-------------------------------------------------------------------------------------------
             */
            Derived_class dc = new Derived_class("this is derived class constructor");

            /*-------------------------------------------------------------------------------------------
             * 8. encapsulation and abstraction 
             * ------------------------------------------------------------------------------------------
             */
            Encap_abs ea = new Encap_abs();//object creation
            ea.Name = "Abhishek";  //setting name
            ea.Id = 2;  //setting id
            ea.msg(); // invoking abstract method
            Console.WriteLine("encapsulated method's name   " + ea.Name); //getting name 
            Console.WriteLine("encapsulated method's id    " + ea.Id);    // setting id
            Console.ReadLine();

           
        }
    }
    
    
}
