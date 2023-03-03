using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class overrideexample
    {
        public virtual void eat()
        {
            Console.WriteLine("I eat dog food");
        }

    }
    public class dog1 : overrideexample
    {
       /* static void Main(string[] args)
        {

            overrideexample o = new dog1();
            o.eat();
        }*/
    }


}
