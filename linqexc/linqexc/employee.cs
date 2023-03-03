using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqexc
{
    internal class employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set;}
        public int employeeAge { get; set;}
    }
   /* class Program
    {
        static void Main()
        {
            employee[] emp = {
                new employee() { employeeId = 1, employeeName = "john", employeeAge = 18 },
                new employee() { employeeId = 2, employeeName = "steve", employeeAge = 21 },
                new employee() { employeeId = 3, employeeName = "bill", employeeAge = 25 },
                new employee() { employeeId = 4, employeeName = "ram", employeeAge = 20 },
                new employee() { employeeId = 5, employeeName = "ron", employeeAge = 31 },
                new employee() { employeeId = 6, employeeName = "chris", employeeAge = 17 },
                new employee() { employeeId = 7, employeeName = "rob", employeeAge = 19 },
            };
            employee[] e1 = new employee[10];
            int i = 0;
            foreach(employee e in emp)
            {
                if(e.employeeAge>12 && e.employeeAge<20)
                {
                    e1[i++] = e;
                    Console.WriteLine(e.employeeName);

                }
            }
            Console.ReadLine();
        }
    }*/
}
