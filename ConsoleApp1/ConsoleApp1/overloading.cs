using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class overloading
    {
        public int add(int x, int y)
        {
            int ans = x + y;
            return ans;
        }
        public int add(int x,int y,int z) 
        {
            int ans = x + y+z;
            return ans;

        }
        public int mult(int x, int y)
        {

            int ans = x * y;
            return ans;
        }
        public int mult(int x, int y, int z)
        {
            int ans = x * y*z;
            return ans;

        }
        public int sub(int x, int y)
        {

            int ans = x - y;
            return ans;
        }
        public int sub(int x, int y, int z)
        {

            int ans = x - y-z;
            return ans;

        }

    }
   /* class Program
    {
        static void Main()
        {
            overloading ob=new overloading();
            int sum1=ob.add(10,10);
            int sum2 = ob.add(10, 20, 30);
            int sub1 = ob.sub(10, 10);
            int sub2 = ob.sub(10, 20, 30);
            int mul1 = ob.mult(10, 10);
            int mul2 = ob.mult(10, 20, 30);

            Console.WriteLine(sum1); Console.WriteLine(sum2);
            Console.WriteLine(sub1); Console.WriteLine(sub2);
            Console.WriteLine(mul1); Console.WriteLine(mul2);

        }
    }*/
}
