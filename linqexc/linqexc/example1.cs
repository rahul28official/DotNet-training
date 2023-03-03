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
    internal class example1
    {

    }
    /*class program
    {
        public static void Main()
        {
            string[] names = { "anil", "sharma", "abdullah", "omran", "suman" };
            //UsingLinq(names);
            // UsingLinqExtensions(names);
            // UsingLinqFunctions(names);
            // UsingAnonymousMethods(names);
            // LinqReadXML();
            // LinqToXMLAddNode();
           // LinqToXMLRemoveNode();

        }
        /* public static void UsingLinq(string[] names)
         {
             IEnumerable<string> query = from s in names
                                         where s.Length == 5
                                         orderby s
                                         select s.ToUpper();
             foreach (string items in query)
             {
                 Console.WriteLine(items);
             }
             Console.ReadLine();
         }*/
        /* public static void UsingLinqExtensions(string[] names)
          {
              IEnumerable<string> query=names
                  .Where(s=>s.Length==5)
                  .OrderBy(s=>s)
                  .Select(s=>s.ToUpper());
              foreach (string item in query) 
              { 
              Console.WriteLine(item);
              }
          }*/
        /*public static void UsingLinqFunctions(string[] names)
         {
             Func<string, bool> filter = s => s.Length==5;
             Func<string, string> extract = s => s;
             Func<string, string> project = s => s.ToUpper();
             IEnumerable<string> query = names.Where(filter)
                 .OrderBy(extract)
                 .Select(project);
             foreach(string items in query)
             {
                 Console.WriteLine(items);
             }
             Console.ReadLine();
         }*/

        /*public static void UsingAnonymousMethods(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };

            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };
            IEnumerable<string> query = names.Where(filter)
                                         .OrderBy(extract)
                                         .Select(project);
            foreach (string items in query)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }*/
       /* public static void LinqReadXML()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";
            XDocument xdoc=new XDocument();
            xdoc=XDocument.Parse(myXML);
            var result=xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department name : " + item.Value);
            }
            Console.WriteLine(" press any key to continue ");
            Console.ReadLine();

        }*/
      /* public static void LinqToXMLAddNode()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Finance"));
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department name : " + item.Value);
            }
            Console.WriteLine(" press any key to continue ");
            Console.ReadLine();
        }*/

       /* public static void LinqToXMLRemoveNode()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department name : " + item.Value);
            }
            Console.WriteLine(" press any key to continue ");
            Console.ReadLine();
        }*/


    }

