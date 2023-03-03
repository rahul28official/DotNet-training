using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class overloading2
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public double add(double x, double y) 
        
        { double ans=x+y;
            return ans;
        }
    }

    /*class Program
    {
        static void Main()
        {
            overloading2 ob=new overloading2(); 
            int add1=ob.add(1,2);

            double add2=ob.add(1.0,25.0);
            Console.WriteLine(add1);
            Console.WriteLine(add2);
        }
    }*/
}
