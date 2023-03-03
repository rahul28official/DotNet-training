using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbsMotorbike
    {
        public abstract void brake();
    }

    class sportsbike : AbsMotorbike
    {
        public override void brake()
        {
            Console.WriteLine("sportsbike brake");
        }
    }
    class mountainbike : AbsMotorbike
    {
        public override void brake()
        {
            Console.WriteLine("mountinbike brake");
        }
    }
  /*  class Program
    {
        static void Main()
        {
            sportsbike s= new sportsbike();
            mountainbike m= new mountainbike(); 
            s.brake();
            m.brake();
        }
    }*/
}
