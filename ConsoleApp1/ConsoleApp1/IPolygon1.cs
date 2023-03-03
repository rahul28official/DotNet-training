using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPolygon1
    {
        public void calculatearea();
    }

    public class rect : IPolygon1
    {
        public void calculatearea()
        {
            int l = 10;
            int b = 20;
            Console.WriteLine("area of rectangle is : " + l * b);
        }
    }

    public class sq : IPolygon1
    {
        public void calculatearea()
        {
            int l = 10;
            Console.WriteLine("area of square is : " + l * l);
        }
    }

    /* public class Program
     {
         static void Main()
         {
             rect r= new rect();
             sq s= new sq();
             r.calculatearea();
             s.calculatearea();
         }
     }*/
}
