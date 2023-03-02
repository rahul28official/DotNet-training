using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adodotnet
{
    internal class LINQqueryExamples
    {
       /* public class employee
        {
            public int employeeId { get; set; }
            public string employeeName { get; set; }
            public int projectId { get; set; }
        }
        public class project
        {
            public int projectId { get; set;}
            public string projectName { get; set; }
        }
         public class Program
        {
            public static List<employee> emp=new List<employee>();
            public static List<project> prj=new List<project>();
            public static void initializeEmployee()
            {
                emp.Add(new employee 
                {
                    employeeId = 1,
                    employeeName="Tuba",
                    projectId=100
                
                });
                emp.Add(new employee
                {
                    employeeId = 2,
                    employeeName = "Atul",
                    projectId = 101

                });
                emp.Add(new employee
                {
                    employeeId = 3,
                    employeeName = "Theran",
                    projectId = 101

                });
            }
            public static void initializeProject()
            {
                prj.Add(new project
                {
                    projectId=100,
                    projectName="ABC"
                });
                prj.Add(new project
                {
                    projectId = 101,
                    projectName = "PQR"
                });
            }
            public static void Main()
            {
                initializeEmployee();
                initializeProject();

                //where in query syntax
                var querysyntax1 = from employee in emp
                                   where employee.employeeName.StartsWith("T")
                                   select employee.employeeName;
                Console.WriteLine("where in query syntax ");
                foreach(var items in querysyntax1)
                {
                    Console.WriteLine(items);
                }

                //method syntax
                var methodsyntax1=emp.Where(e=>e.employeeName.StartsWith("T"));
                Console.WriteLine("where in method syntax ");
                foreach (var items in methodsyntax1)
                {
                    Console.WriteLine(items.employeeName);
                }

                Console.WriteLine("\n");

                //order by using query syntax
                var querysyntax2=from employee in emp
                                 orderby employee.employeeName
                                 select employee.employeeName;
                //order by using method syntax
                var methodsyntax2=emp.OrderBy(e=> e.employeeName);
                Console.WriteLine("order by  in query syntax ");
                foreach (var items in querysyntax2)
                {
                    Console.WriteLine(items);
                }
                Console.WriteLine("order by in method syntax ");
                foreach (var items in methodsyntax2)
                {
                    Console.WriteLine(items.employeeName);
                }

                Console.WriteLine("\n");

                //order by descending  using query syntax
                var querysyntax3 = from employee in emp
                                   orderby employee.employeeName  descending      
                                   select employee.employeeName;
                //order by descending  using method syntax
                var methodsyntax3 = emp.OrderByDescending(e => e.employeeName);
                Console.WriteLine("order by descending in query syntax ");
                foreach (var items in querysyntax3)
                {
                    Console.WriteLine(items);
                }
                Console.WriteLine("order by descending in method syntax ");
                foreach (var items in methodsyntax3)
                {
                    Console.WriteLine(items.employeeName);
                }

                Console.WriteLine("\n");

                //then by (ordering by two columns)
                //multiple order by descending  using query syntax
                var querysyntax4 = from employee in emp
                                   orderby employee.projectId,employee.employeeName descending
                                   select employee;
                //multiple order by descending  using method syntax
                var methodsyntax4 = emp.OrderBy(e => e.projectId).ThenByDescending(e=>e.employeeName);
                Console.WriteLine("multiple order by descending in query syntax ");
                foreach (var items in querysyntax4)
                {
                    Console.WriteLine(items.employeeName+" : "+items.projectId);
                }
                Console.WriteLine("multiple order by descending in method syntax ");
                foreach (var items in methodsyntax4)
                {
                    Console.WriteLine(items.employeeName + " : "+items.projectId);
                }

                Console.WriteLine("\n");

                //take 
                //take  using query syntax
                var querysyntax5 = (from employee in emp select employee).Take(2);
                                  
                //take  using method syntax
                var methodsyntax5 = emp.Take(2);
                Console.WriteLine("take in query syntax ");
                foreach (var items in querysyntax5)
                {
                    Console.WriteLine(items.employeeName);
                }
                Console.WriteLine("take in method syntax ");
                foreach (var items in methodsyntax5)
                {
                    Console.WriteLine(items.employeeName);
                }

                Console.WriteLine("\n");

                //skip
                //skip  using query syntax
                var querysyntax6 = (from employee in emp select employee).Skip(2);

                //skip  using method syntax
                var methodsyntax6 = emp.Skip(2);
                Console.WriteLine("skip in query syntax ");
                foreach (var items in querysyntax6)
                {
                    Console.WriteLine(items.employeeName);
                }
                Console.WriteLine("skip in method syntax ");
                foreach (var items in methodsyntax6)
                {
                    Console.WriteLine(items.employeeName);
                }

                Console.WriteLine("\n");

                //group
                //group  using query syntax
                var querysyntax7 = (from employee in emp
                                    group employee by employee.projectId);

                //grou  using method syntax
                var methodsyntax7 = emp.GroupBy(e=>e.projectId);
                Console.WriteLine("group by in query syntax ");
                foreach (var items in querysyntax7)
                {
                    Console.WriteLine(items.Key+" : "+items.Count());
                }
                Console.WriteLine("group by in method syntax ");
                foreach (var items in methodsyntax7)
                {
                    Console.WriteLine(items.Key + " : " + items.Count());
                }

                Console.WriteLine("\n");

                //first
                //first using query syntax
                var querysyntax8 = (from employee in emp
                                        //where employee.employeeName.StartsWith("Q")
                                    select employee).First();

                //first using method syntax
                var methodsyntax8 = emp
                                   // .Where(e=>e.employeeName.StartsWith("Q"))
                                   .First();
                Console.WriteLine("first  in query syntax ");
                if(querysyntax8 != null)
                {
                    Console.WriteLine(querysyntax8.employeeName);
                }
                Console.WriteLine("first  in method syntax ");
                if(methodsyntax8 != null)
                {
                    Console.WriteLine(methodsyntax8.employeeName);
                }
                

                Console.WriteLine("\n");

                //first or default
                //first or default using query syntax
                
                var querysyntax9 = (from employee in emp
                                        where employee.employeeName.StartsWith("Q")
                                    select employee).FirstOrDefault();

                //first or default  using method syntax
                var methodsyntax9 = emp
                                   .Where(e=>e.employeeName.StartsWith("Q"))
                                   .FirstOrDefault();
                Console.WriteLine("first  in query syntax ");
                if (querysyntax9 != null)
                {
                    Console.WriteLine(querysyntax9.employeeName);
                }
                Console.WriteLine("first  in method syntax ");
                if (methodsyntax9 != null)
                {
                    Console.WriteLine(methodsyntax9.employeeName);
                }


                Console.WriteLine("\n");

                //join
                //join  using query syntax
                var querysyntax10 = from employee in emp
                                    join project in prj on employee.projectId equals project.projectId
                                    select new { employee.employeeName, project.projectName };

                //join  using method syntax
                var methodsyntax10 = emp.Join(prj,
                                               e=>e.projectId,
                                               p=>p.projectId,
                                               (e,p)=> new {e.employeeName,p.projectName});
                Console.WriteLine("join in query syntax ");
                foreach (var items in querysyntax10)
                {
                    Console.WriteLine(items.employeeName + " : " + items.projectName);
                }
                Console.WriteLine("join  in method syntax ");
                foreach (var items in methodsyntax10)
                {
                    Console.WriteLine(items.employeeName + " : " + items.projectName);
                }

                Console.WriteLine("\n");

                //left join with nullable object (project---- line 281)
                var querysyntax11=from employee in emp
                                  join project in prj on employee.projectId equals project.projectId into group1
                                  from project in group1.DefaultIfEmpty()
                                  select new { employee.employeeName,projectName=project?.projectName??"NULL"};

                Console.WriteLine("left join  in query syntax ");
                foreach (var items in querysyntax11)
                {
                    Console.WriteLine(items.employeeName + " : " + items.projectName);
                }

                //multi select
                int[] numberA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numberB = { 1, 3, 5, 7, 8 };
                var pairs = from a in numberA from b in numberB where a < b select new { a, b };
                Console.WriteLine("Pairs where a<b : ");
                foreach(var item in pairs)
                {
                    Console.WriteLine("{0} is less then {1} ", item.a, item.b);
                }
                Console.WriteLine("\n");

                int[] factorsof300 = { 2, 2, 3, 5, 5 };
                int uniquefactors = factorsof300.Distinct().Count();
                Console.WriteLine("There  are {0} unique factors of 300.",uniquefactors);
                Console.WriteLine("\n");
                    
                //applyling logic in linq
                int[] number = { 5, 4, 56, 8, 9, 6, 10 };
                int oddNum=number.Count(n=>n%2==1);
                Console.WriteLine("There  are {0} odd number in the list ", oddNum);
                Console.WriteLine("\n");

                //except
                Console.WriteLine("except");
                List<string> list1 = new List<string>() { "one", "two", "three", "four", "five" };
                List<string> list2 = new List<string>() {  "four", "five" ,"six","seven"};
                var result =list1.Except(list2);
                foreach(string str in result)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("\n");

                //intersect
                Console.WriteLine("intersect");
                List<string> list3 = new List<string>() { "one", "two", "three", "four", "five" };
                List<string> list4 = new List<string>() { "four", "five", "six", "seven" };
                var result1 = list3.Intersect(list4);
                foreach (string str in result1)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("\n");


                //union
                Console.WriteLine("union");
                List<string> list5 = new List<string>() { "one", "two", "three", "four", "five" };
                List<string> list6 = new List<string>() { "four", "five", "six", "seven" };
                var result2 = list3.Union(list4);
                foreach (string str in result2)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("\n");

                //tolist and toarray
                Console.WriteLine("toarray and tolist");
                IList<string> strlist = new List<string>() { "one", "two", "three", "four", "three" };
                string[] strarray = strlist.ToArray();//converts list to array
                IList<string> list = strarray.ToList<string>();//converts array into list
                foreach (string str in list)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("\n");
                foreach (string str in strarray)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("\n");

                //average
                IList<int> intlist = new List<int>() { 10, 20, 30 };
                var avg = intlist.Average();
                Console.WriteLine("average : {0} ", avg);
                Console.WriteLine("\n");
              




            }
        }*/
    }
}
