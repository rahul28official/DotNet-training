using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbsClass
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public abstract int  mul (int x, int y);

    }
    class derived: AbsClass
    {
        public override int mul(int x, int y)
        {
            return x * y;
        }
    }
   /* class Program
    {
        static void Main()
        {
            derived d=new derived(); 
            int add=d.add(1,2);
            int mul=d.mul(1,2);
            Console.WriteLine("addition is :"+add);
            Console.WriteLine("derived is :" + mul);
        }
    }*/
}
