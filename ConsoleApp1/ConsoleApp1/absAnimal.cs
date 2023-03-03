using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class absAnimal
    {
        public abstract void makesound();
    }
    class cat : absAnimal
    {
        public override void makesound()
        {
            Console.WriteLine("mew");
        }
    }
   /* class Program
    {
        static void Main()
        {
            cat c= new cat();
            c.makesound();
        }
    }*/
}
