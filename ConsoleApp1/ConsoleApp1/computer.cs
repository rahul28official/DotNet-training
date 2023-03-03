using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class computer
    {
        public void display()
        {
            Console.WriteLine("method of computer class");
        }
        public class cpu
        {

        }
    }
    class laptop : computer
    {

    }
    /* class Program
     {
         static void Main()
         {
             laptop obj = new laptop();
             obj.display();

         }
     }*/
}
