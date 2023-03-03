using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    internal class access  // access modifier example
    {
        public void show1() // can be accessed anywhere 
        {
            Console.WriteLine("i am public ");
        }
        private void show2() // can be access in this class only
        {
            Console.WriteLine("i am private");
        }

        protected void show3() // can be accessed in this class and its child class only
        {
            Console.WriteLine("i am protected");
        }
    }

   

   /* class Program : access
    {
        static void Main()
        {
            Program e1=new Program();
           

            e1.show1(); //public
            //e1.show2(); // private
            e1.show3(); // protected

        }
    }*/
}
