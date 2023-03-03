using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("i am an animal");

        }
    }

    class dog : animal
    {
        public void getName()
        {
            Console.WriteLine("My name is" + name);
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            dog lab=new dog();
            lab.name = "piku";
            lab.display();
            lab.getName();
            Console.ReadLine();
        }
}*/
}
