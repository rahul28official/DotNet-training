using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class alphabetarrange
    {
    }
   /* class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the length of the array");
            int x=Convert.ToInt32(Console.ReadLine());
            char []arr=new char[x];

            Console.WriteLine("enter the alphabets");
            for(int i=0;i<x;i++)
            {
                arr[i] = Console.ReadLine()[0];
            }
            for(int i=0;i< arr.Length-1;i++) 
            {   
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                       char temp= arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1]= temp;
                    }
                } 
            }
            Console.WriteLine("the sorted array is ");
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }*/
}
