using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class loan
    {
        public virtual void CalcLoan()
        {
            Console.WriteLine("I am in loan");
        }
    }
   public  class personalloan : loan
    {
       
            public override void CalcLoan()
            {
                Console.WriteLine("I am in personal loan");
            }
              
    }

    /*public class Progam
    {
        public static void Main()
        {
            loan l=new personalloan();
            l.CalcLoan();
        }
    
    }*/



}
