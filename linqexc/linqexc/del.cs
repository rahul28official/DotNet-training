using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqexc

{
    delegate void customdel(string s);
    internal class del
    {

    }
   /* class Program
    {
        static void hello(string s)
        {
            Console.WriteLine("hello {0}",s);
        }
        static void bye(string s)
        {
            Console.WriteLine("byebye {0}", s);
        }
       static void Main()
        {
            customdel hidel, byedel,multidel,multiminusdelegate;

            hidel = hello;
            byedel = bye;
            multidel = hidel + byedel;
            multiminusdelegate = multidel - hidel;

            Console.WriteLine("invoking delegate hidel");
            hidel("a");
            Console.WriteLine("invoking delegate byedel");
            byedel("a");
            Console.WriteLine("invoking multi cast byedel");
            multidel("c");
            Console.WriteLine("invoking multi minus delegate ");
            multiminusdelegate("d");
            Console.Read();
        }
    }*/
}
