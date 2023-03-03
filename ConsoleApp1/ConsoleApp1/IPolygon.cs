using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPolygon
    {
    public void calculateArea(int x, int y);
    }
    public interface IColour
    {
       public  void getColour();
    }
    class rectangle1 : IPolygon,IColour
    { 
        public void calculateArea(int x,int y)
        {
            Console.WriteLine("Area of rectangle =" + x * y);

        }
        public void getColour()
        {
            Console.WriteLine("red rectangle");
        }

    }
   /* class Program
    {
        static void Main()
        {
            rectangle1 r = new rectangle1();
            r.calculateArea(2, 3);
            r.getColour();

        }
    }*/




   }
