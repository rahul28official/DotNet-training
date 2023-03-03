using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class mobile
    {
        public virtual void mobName(string s)
        {
            Console.WriteLine("the mobile name is "+s);

        }
        public string year = "2000";
        public string simType = "dual";

    }

    class iphone : mobile
    {
        public override void mobName(string s)
        {
            
            Console.WriteLine("the iphone name is " + s);
        }
    }

   /* class Program
    {
        static void Main()
        {
            iphone i=new iphone();
            Console.WriteLine("the mobile is manufactured in the year :" + i.year + " the sim type is : " + i.simType);
            i.mobName("iphone 14 pro max");

        }
    }*/
}
