using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class computer2
    {
        public class cpu
        {
            public void display()
            {
                Console.WriteLine("method of cpu");
            }
        }
    }
    class laptop1 : computer2.cpu
    {

    }
    /*class Program
    {
        static void Main()
        {
            laptop1 obj=new laptop1(); 
            obj.display();
        }
    }*/
}
