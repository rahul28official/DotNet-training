using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class cars
    {
        string car_type = "4 by 4";
        int car_length = 4;
       public  void basicInfo()
        {
            Console.WriteLine("the car is " + car_type + " the length of the car is (in meters) :" + car_length);
        }

    }
    class thar : cars
    {
       public string colour = "black";
       public string tyre_type="alloy";
        public void showmileage(int x)
        {
            Console.WriteLine("the mileage for the car is " + x +" kmpl");
        }

    }

   /* class Program
    {
        static void Main()
        {
            thar obj = new thar();
            obj.basicInfo();
            Console.WriteLine("the car colour is "+obj.colour);
            Console.WriteLine("the tyre type is "+obj.tyre_type);
            obj.showmileage(12);


        }
    }*/
}
