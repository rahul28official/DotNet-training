using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbsLoan
    {
         public void calculateinterest(int principal)
        {
            double interest = 0.15 * principal;
            Console.WriteLine("the interest is :" + interest);

        }
        public abstract double calculateloan(int principal);
    }
    class studentloan : AbsLoan
    {
        public override double calculateloan(int principal)
        {
            double loan = principal + 0.18 * principal;
            return loan;
        }
    }
    class educationloan : AbsLoan
    {
        public override double calculateloan(int principal)
        {
            double loan = principal + 0.15 * principal;
            return loan;
        }
    }

   /* class Program
    {
        static void Main()
        {
            studentloan s=new studentloan();
            educationloan e=new educationloan();
            
            s.calculateinterest(10000);
            double l1=s.calculateloan(10000);
            double l2 =e.calculateloan(10000);
            Console.WriteLine("the loan for studentloan is :" + l1);
            Console.WriteLine("the loan for educationloan is :" + l2);
        }
    }*/
}
