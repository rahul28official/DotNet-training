using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class person
    {
        public void getName()
        {
            //some printing
        }
        public void getAge()
        {
            //some printing

        }
    }

    class employee : person
    {
        public void getYearsOfExp()
        {
            //some printing
        }
        public void GetEmpId()
        {
            //some printing
        }
    }

    class customer: person
    {
        public void getCustUserId()
        {
            //some printing
        }
        public void getAccNum()
        {
            //some printing
        }
    }

   /* class Program
    {
        static void Main(string[] args)
        {
            employee e=new employee();
            e.getName();
            e.getAge();
            e.GetEmpId();
            e.getYearsOfExp();
            
            customer c=new customer();
            c.getName();
            c.getAge();
            c.getCustUserId();
            c.getAccNum();
            

        }
    }*/
}
