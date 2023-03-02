using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adodotnet
{
    internal class practiceques
    {
       /* public class Program
        {
            class CURDonCollegeDB1
            {
                SqlConnection conn;
                public CURDonCollegeDB1()
                {
                    conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=College1; Integrated Security=true");
                }
                static void Main()
                {
                    CURDonCollegeDB1 db = new CURDonCollegeDB1();
                    Console.WriteLine("Department table is shown below");
                    db.ReadData();
                    Console.WriteLine("Table after Updation");
                    db.UpdateData();
                    db.ReadData();
                    Console.WriteLine("Table after Insertion");
                    db.InsertData();
                    db.ReadData();
                    Console.WriteLine("Table after Deletion");
                    db.DeleteData();
                    db.ReadData();

                }
                public void ReadData()
                {
                    SqlDataReader rdr = null;
                    try
                    {

                        SqlCommand cmd = new SqlCommand("Select * from Department", conn);
                        conn.Open();

                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr[0] + " ---------- " + rdr[1]);
                        }
                    }
                    finally
                    {
                        if (rdr != null)
                        {
                            rdr.Close();
                        }
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }


                }

                public void UpdateData()
                {

                    try
                    {

                        SqlCommand cmd = new SqlCommand("Update Department set DepartmentName='Mechanical' where DepartmentName='IT'", conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    finally
                    {

                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }


                }

                public void InsertData()
                {

                    try
                    {

                        SqlCommand cmd = new SqlCommand("Insert into Department values(6,'Production')", conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    finally
                    {

                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }


                }
                public void DeleteData()
                {

                    try
                    {

                        SqlCommand cmd = new SqlCommand("Delete from Department where DepartmentID=6", conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    finally
                    {

                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }


                }
            }

        }*/
    }
}
