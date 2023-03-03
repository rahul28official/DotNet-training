using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class measure
    {

        public void area(int x)
        {
            Console.WriteLine("area of the square is " + x * x);
        }

        public void area(int x,int y)
        {
            Console.WriteLine("area of the rectangle is " + x * y);
        }
    }

   /* class Program
    {
        static void Main()
        {
            measure m=new measure();
            m.area(5);
            m.area(5, 10);
        }
    }*/
}
