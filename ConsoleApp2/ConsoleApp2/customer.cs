using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class customer
    {
        public  int custId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string phoneNum { get; set; }
    }
    class customeroperations
    {
        List<customer> c;
        public customeroperations()
        {
            c = new List<customer>();
        }
        public void addCust(customer cc)
        {
            c.Add(cc);
        }
        public void removeCust(int id)
        {
            for (int i = 0; i < c.Count; i++)
            {
                if (c[i].custId == id)
                {
                    c.RemoveAt(i);
                }
            }
        }
        public List<customer> getCust()
        {
            return c;
        }
    }

    class Program
    {
        static void Main()
        {
            customeroperations co = new customeroperations();
            co.addCust(new customer() {custId = 1, Fname = "John", Lname = "Doe", phoneNum = "90239043" });
            co.addCust(new customer() { custId = 2, Fname = "rohit", Lname = "sharma", phoneNum = "90239056743" });
            
            co.removeCust(1);
            foreach(var items in co.getCust())
            {
                Console.WriteLine(items.Fname);
            }
        }
    }

}
