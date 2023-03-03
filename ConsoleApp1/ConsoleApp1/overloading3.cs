using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class overloading3
    {
        public void identity(string name, int id)
        {
            Console.WriteLine("name1 : "+name+  "   id1 : "+id);
        }
        public void identity(int id , string name)
        {
            Console.WriteLine("name2 : " + name + "   id2 : " + id);
        }
    }

   /* class Program
    {
        static void Main()
        {
            overloading3 ob = new overloading3();
            ob.identity("rahul", 1);
            ob.identity(2, "rishi");
        }
    }*/


}
