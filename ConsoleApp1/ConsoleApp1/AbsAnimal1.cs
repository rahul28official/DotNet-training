using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbsAnimal1
    {
        protected string name;
        public abstract string Name
        {
            get;
            set;

        }
    }
    class zebra : AbsAnimal1
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
    }
    /*class Program
    {
        static void Main()
        {
            zebra z=new zebra();
            z.Name=("piku");
            Console.WriteLine("name "+z.Name);
        }
    }*/
}
