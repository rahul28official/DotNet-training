using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public interface IEmployee
    {
        public void getfirstname();
        public void getlastname();
    }

    class employeedetails : IEmployee
    {
        public void getfirstname()
        {
            Console.WriteLine("rahul");
        }
        public void getlastname()
        {
            Console.WriteLine("shaw");
        }
    }

   /* class Program
    {
        static void Main()
        {
            employeedetails e=new employeedetails(); 
            e.getfirstname();
            e.getlastname();

        }
    }*/
}
