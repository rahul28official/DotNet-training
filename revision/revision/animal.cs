using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    internal class animal //overriding example
    {
       public  virtual void show()
        {
            Console.WriteLine("Animals are of two types, flesh eating and plant eating");
        }
    }
    class carnivore : animal 
    {
        public  override void show()
        {
            Console.WriteLine("carnivore only eat flesh");
        }
    }
    /*class Program
    {
        static void Main()
        {
            carnivore c=new carnivore();
            animal a=new animal();

            a.show(); // shows the show method in the parent class
            c.show(); // shows the show method of the child class that has ovverriden the definition of show() method
        }
    }*/

}
