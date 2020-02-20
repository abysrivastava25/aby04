using System;
using System.Collections.Generic;
using System.Text;

namespace session_oops
{
    //abstract class
    abstract class Demo_abs
    {
        public abstract void msg();
        public void msg2()
        {
            Console.WriteLine("hey");
        }

    }
    //encapsulated class having private members 
    class Encap_abs:Demo_abs
    {
        private string name;
        private int id;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Id
        {
            get {
                return id;
            }
            set {
                id = value;
            }
        }
        //abstract method's implementation
        public override void msg()
        {
            Console.WriteLine("abstract class method is invoked");
        }
    }

    

}
