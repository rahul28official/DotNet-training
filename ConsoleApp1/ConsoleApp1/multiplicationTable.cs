using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class multiplicationTable
    {
       public void table()
        {
            Console.WriteLine("enter a number to print its table");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num+ " * " + i + " = " + (num * i));
            }
        }

}
   /* class Progam
    {
         static void Main(string[] args)
        {
           multiplicationTable t=new multiplicationTable();
            t.table();

        }
    }*/
}
