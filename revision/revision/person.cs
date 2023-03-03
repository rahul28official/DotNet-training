using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
     class person  //inheritance example
    {
        string name;  //common details for anyone in a bank 
        int age;
        public void getinfo(string name, int age)
        {
            this.name= name;
            this.age= age;
            Console.WriteLine("name is :" + name + "age is :" + age);
        }
    }
    class user:person
    {
        int userid;  //details associated only with user
        int accNum;
        public void empdetails(int userid, int accNum)
        {
            this.userid= userid;
            this.accNum= accNum;
            Console.WriteLine("employee id :" + userid + " account number : " + accNum);
        }
    }

   /* class Program
    {
        static void Main()
        {
            user e = new user();
            e.getinfo("ravi kumar", 34);
            e.empdetails(123, 1235646565);
        }
    }*/
}
