using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class car
    {
        public void displaycar()
        {
            Console.WriteLine("car :bugatti ");
        }
        public class engine
        {
            public void displayengine()
            {
                Console.WriteLine("engine : petrol engine");

            }
        }
    }
   /* class Program
    {
        static void Main()
        {
            car sportscar = new car();
            sportscar.displaycar();
            car.engine petrolengine = new car.engine();
            petrolengine.displayengine();
        }
    }*/
}
