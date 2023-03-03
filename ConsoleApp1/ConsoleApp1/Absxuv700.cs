using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Absxuv700
    {
        public void cardetails (string model)
        {
            Console.WriteLine ("the car model is :"+model);
        }

        public abstract void Colour(string clr);

    }

    class person1 : Absxuv700
    {
        public override void Colour(string clr )
        {
            Console.WriteLine("the person has choosen colour :" + clr);
        }
    }

    /*class Program
    {
        static void Main()
        {
            person1 p =new person1();
            p.cardetails("topmodel diesel");
            p.Colour("electric blue");

        }
    }*/
}
