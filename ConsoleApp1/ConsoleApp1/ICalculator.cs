using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculator
    {
        public void add();
        public void mul();
        public void sub();
        public void div();
    }

    public class clac : ICalculator 
    
    {
        public void add()
        {
            Console.WriteLine("i am in add");
        }
        public void sub()
        {
            Console.WriteLine("i am in sub");

        }
        public void mul()
        {
            Console.WriteLine("i am in mul");
        }
        public void div()
        {
            Console.WriteLine("i am in div");
        }



    }

    /*class Program
    {
        static void Main()
        {
            clac e = new clac();
            e.add();
            e.sub();
            e.mul();
            e.div();

        }
    }*/

}
