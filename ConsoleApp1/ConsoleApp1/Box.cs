using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Box
    {
        private double length;
        private double breadth;
        private double height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth  = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public static Box operator + (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length+c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height+c.height;
            return box;
        }
    }
   /* class Program
    {
        static void Main()
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume = 0.0;

            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            volume = Box1.getVolume();
            Console.WriteLine("volume of box1= " + volume);

            volume = Box2.getVolume();
            Console.WriteLine("volume of box2= " + volume);

            Box3=Box1+Box2;
            volume=Box3.getVolume();
            Console.WriteLine("volume of box3= " + volume);

            Console.ReadLine();









        }
    }*/
}
