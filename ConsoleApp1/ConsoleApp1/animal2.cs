using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class animal2
    {
        public virtual void makesound()
        {
            Console.WriteLine("animal sound");
        }
    }
    class doggy : animal2
    {
        sealed public override void makesound()
        {
            Console.WriteLine("DOG SOUNd");
        }
    }
    //class puppy : doggy
    //{
        //public override void makesound()
        //{
           // Console.WriteLine("puppy sound");
       // }//
   // }
    /*class Program
    {
        static void Main()
        {
            puppy d=new puppy();
            Console.ReadLine();
        }
    }*/
}
