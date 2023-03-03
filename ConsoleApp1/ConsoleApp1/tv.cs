using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class tv
    {
        public void display1()
        {
            Console.WriteLine("I am a tv");
        }
         
    }

    class smartTV : tv
    {
        public void display2()
            {
            Console.WriteLine("I am a smart tv");
        }

    }

    class miTV : smartTV
    {
        public void display3()
            {
            Console.WriteLine("I am a MI smart TV with more exciting features ");
        }
    }

    /*public class Program
    {
        static void Main(string[] args)
        {
            miTV obj = new miTV();
            obj.display1();
            obj.display2();
            obj.display3();
            Console.ReadLine();
        }


    }*/
}
