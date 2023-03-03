using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    internal class calculate //overloading example
    {
        public void area(int x,int y) // same method name but diff parameter
        {
            Console.WriteLine("the area of the rectangle is :" + x * y);
        }
        public void area(int x)
        {
            Console.WriteLine("the area of the square is :" + x * x);
        }


    }
    /*class Program
    {
        static void Main()
        {
            calculate c=new calculate();
            c.area(5);
            c.area(5, 10);
        }
    }*/
}
