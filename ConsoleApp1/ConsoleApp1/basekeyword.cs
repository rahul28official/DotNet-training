using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class basekeyword
    {
        public virtual void CalcLoan()
        {
            Console.WriteLine("I am in loan");
        }
    }
     class p1 : basekeyword
    {

        public override void CalcLoan()
        {
            base.CalcLoan();
            Console.WriteLine("I am in personal loan");
        }

    }
    /*public class Progam
    {
        public static void Main()
        {
            basekeyword l = new p1();
            l.CalcLoan();
        }

    }
    */

}
