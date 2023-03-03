using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class employee1
    {
       public int empid;
       public string fname;
       public string lname;
       public int salary;

        public void setempid(int emp)
        {
            empid = emp;
        }
        public void setfname(string first)
        {
            fname = first;
        }
        public void setlname(string last)
        {
            lname = last;
        }
        public void setsal(int sal) 
        {
            salary = sal;
        }

        public static employee1 operator > (employee1 emp1,employee1 emp2)
        {
             employee1 e=new employee1();
            if( emp1.salary > emp2.salary)
            {
                e.salary = emp1.salary;
                e.fname = emp1.fname;
                e.lname= emp1.lname;
                e.empid= emp1.empid;
            }
            else
            {
                e.salary = emp2.salary;
                e.fname = emp2.fname;
                e.lname = emp2.lname;
                e.empid = emp2.empid;

            }
            return e;
        }
        public static employee1 operator < (employee1 emp1, employee1 emp2)
        {
            employee1 e = new employee1();
            if (emp1.salary > emp2.salary)
            {
                e.salary = emp1.salary;
                e.fname = emp1.fname;
                e.lname = emp1.lname;
                e.empid = emp1.empid;
            }
            else
            {
                e.salary = emp2.salary;
                e.fname = emp2.fname;
                e.lname = emp2.lname;
                e.empid = emp2.empid;

            }
            return e;
        }
    }

    /*class Program
    {
        static void Main()
        {
            employee1 e1=new employee1(); 
            employee1 e2=new employee1();
            employee1 e3=new employee1();

            e1.setempid(1);
            e1.setfname("anil");
            e1.setlname("kapoor");
            e1.setsal(15000);

            e2.setempid(2);
            e2.setfname("arun");
            e2.setlname("sharma");
            e2.setsal(16000);

            e3 = e1 > e2;
            Console.WriteLine("the greater salary is acheived by : " + e3.fname + " and the salary is :" + e3.salary);


        }


    }*/
}
