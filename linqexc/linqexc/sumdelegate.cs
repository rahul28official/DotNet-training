using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqexc
{
    internal class sumdelegate
    {
        public delegate int sumoperation(int x,int y);

       /* class Program
        {
            static int sum(int a,int b)
            {
                return a + b;
            }
            static void Main()
            {
                sumoperation add = sum;
                int result = add(10, 10);
                Console.WriteLine(result);
            }
        }*/
    }
}
