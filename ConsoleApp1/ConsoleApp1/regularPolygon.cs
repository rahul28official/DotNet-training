using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class regularPolygon
    {
        public void calculatePerimeter(int length, int sides)
        {
        int result = length * sides;
        Console.WriteLine("perimeter: "+result);

        }


    }
    class square: regularPolygon
    {
    public int length = 200;
    public int sides = 4;
    public void calculateArea()
    {
        int area = length * length;
        Console.WriteLine("area of squares: " + area);
    }

    }


    class rectangle:regularPolygon
{

    public int length = 100;
    public int breadth = 200;
    public int sides = 4;
    public void calculateArea()
    {
        int area = length * breadth;
        Console.WriteLine("area of rectangle: " + area);
    }
}


    /*class Program
    {       static void Main()
                 {
                square s1 = new square();
                  s1.calculateArea();
                    s1.calculatePerimeter(s1.length, s1.sides);

                 rectangle t1 = new rectangle();
             t1.calculateArea();
            t1.calculatePerimeter(t1.length, t1.sides);
    }

    
}*/
}
