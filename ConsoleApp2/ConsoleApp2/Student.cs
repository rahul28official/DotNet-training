using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
       
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
    }

    class StudentOperations
    {
        List<Student> students;
        public StudentOperations()
        {
            students= new List<Student>();

        }
        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }

    /*class Program
    {
        static void Main()
        {
            StudentOperations s=new StudentOperations();
            s.AddStudent(new Student() { StudentId=123,FirstName="rahul",LastName="shaw",Location="kolkata"});
            s.AddStudent(new Student() { StudentId = 134, FirstName = "rakesh", LastName = "shaw", Location = "kolkata" });
            foreach(var student in s.GetStudents())
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.Location);
            }

        }
    }*/
}
