using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    internal interface calculateArea //interface example
    {
        public void calculateArea();
    }

    class rectangle : calculateArea
    {
        public void calculateArea()
        {
            int l = 10;
            int b = 20;
            Console.WriteLine("area of rectangle is :" + l * b);
        }
    }
    class square : calculateArea
    {
        public void calculateArea()
        {
            int s = 10;
            Console.WriteLine("area of the square is :" + s * s);
        }
    }
   /* class Program
    {
        static void Main()
        {
            rectangle r=new rectangle();
            square s=new square();  
            r.calculateArea();
            s.calculateArea();
        }
    }*/
}
