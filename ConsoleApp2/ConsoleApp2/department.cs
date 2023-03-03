using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class department
    {
        public int deptId { get; set; }
        public string deptName { get; set;}   
        public string deptLoc{ get; set;}
    }

    class departmentoperations
    {
        List<department> departmentList;
        public departmentoperations() 
        { 
            departmentList = new List<department>();
        }
        public void addDepartment(department d)
        {
            departmentList.Add(d);
        }
        public List<department> getDepartment()
        {
            return departmentList;
        }

    }

   /* class Program
    {
        static void Main()
        {

            departmentoperations dd1 = new departmentoperations();


            department d1 = new department();
            d1.deptId = 1;
            d1.deptName = "IT";
            d1.deptLoc = "kolkata";
            dd1.addDepartment(d1);


            department d2 = new department();
            d2.deptId = 2;
            d2.deptName = "IT";
            d2.deptLoc = "kolkata";
            dd1.addDepartment(d2);


            foreach (var dept in dd1.getDepartment())
            {
                Console.WriteLine(dept.deptId);
                Console.WriteLine(dept.deptName);
                Console.WriteLine(dept.deptLoc);

            }
   
        }
            
    }*/
    
}
