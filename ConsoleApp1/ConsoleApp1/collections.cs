using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class collections
    {
    }
     class Program
     { 
         static void Main()
         {
             List<int> l = new List<int>();
             l.Add(1);
             l.Add(2);
             l.Add(3);

             for(int i=0;i<l.Count;i++)
             {
                 Console.WriteLine(l[i]);
             }
             foreach(var item in l)
                 {
                     Console.WriteLine(item);
                }
             l.ForEach(x => Console.WriteLine(x)); //LambdaExpression 
             List<string> s = new List<string>();
            s.Add("a");               
            s.Add("b");
            s.Add("c");

            List<string> t = new List<string>{ "c", "d" }; //direct initialisation
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i]);
            }

            List<int> l2= new List<int>();
            l2.AddRange(l);// adding one list to another

            Console.WriteLine(l.Contains(1));



        }
     }

}
