using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    abstract class salary //abstract class example
    {
        public void showdetails(string name,int age)
        {
            Console.WriteLine("Name : " + name + " age : " + age);
        }
        public abstract double calculateSal(int principal);
    }

    class employee : salary
    {
        public override double calculateSal(int principal)
        {
            double amount = principal + (0.15 * principal);
            return amount;
        }
    }

    /*class Program
    {
        static void Main()
        {
            employee e=new employee();
            e.showdetails("rahul", 24);
            double amt =e.calculateSal(10000);
            Console.WriteLine("the salary is : " + amt);
        }
    }*/
}
