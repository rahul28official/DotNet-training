using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace linqexc
{
    internal class employee1
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public int employeeAge { get; set; }
    }
    /*class Program
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

            employee[] teenage = emp.Where(s => s.employeeAge > 12 && s.employeeAge < 20).ToArray();
            foreach(employee e in teenage )
            {
                Console.WriteLine(e.employeeName);
            }

            employee bill=emp.Where(s=>s.employeeName=="bill").FirstOrDefault();
            Console.WriteLine(bill.employeeName);


            employee employee5=emp.Where(s=>s.employeeId==5).FirstOrDefault();
            Console.WriteLine(employee5.employeeName);
           
        }
    }*/
}
