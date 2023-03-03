using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class car2
    {
        public static string brand = "bugatti";
        public class engine
        {
            public void display()
            {
                Console.WriteLine("brand  : " + car2.brand);

            }
        }
    }
   /* class Program
    {
        static void Main()
        {
            car2.engine obj = new car2.engine();
            obj.display();
        }
    }*/
}
