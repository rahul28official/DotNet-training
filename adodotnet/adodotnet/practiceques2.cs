using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adodotnet
{
    internal class practiceques2
    {
        class Program
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
                    //Console.WriteLine("Department table is shown below");
                    //db.ReadData();
                    //Console.WriteLine("Table after Updation");
                    //db.UpdateData();
                    //db.ReadData();
                    //Console.WriteLine("Table after Insertion");
                    //db.InsertData();
                    //db.ReadData();
                    //Console.WriteLine("Table after Deletion");
                    //db.DeleteData();
                    //db.ReadData();
                    db.spCall1();
                    db.spCall2();
                    db.spCall3();
                    db.spCall4();

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

                public void spCall1()
                {
                    SqlDataReader rdr = null;
                    try
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("spShowAllDepartments", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr["DepartmentID"] + " ----%--- " + rdr["DepartmentName"]);
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

                public void spCall2()
                {
                    SqlDataReader rdr = null;

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("spGetAllCoursesofDepartment", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter depname = new SqlParameter
                        {
                            ParameterName = "@DepartmentID",
                            SqlDbType = SqlDbType.Int,
                            Value = "2",
                            Direction = ParameterDirection.Input
                        };
                        cmd.Parameters.Add(depname);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr["CourseName"] + " -------- " + rdr["DepartmentID"]);
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

                public void spCall3()
                {
                    SqlDataReader rdr = null;

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("spCourseOfDepartment", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter course = new SqlParameter
                        {
                            ParameterName = "@Course",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 50,
                            Value = "Communication Systems",
                            Direction = ParameterDirection.Input
                        };
                        SqlParameter depname = new SqlParameter
                        {
                            ParameterName = "@DepName",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 50,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(course);
                        cmd.Parameters.Add(depname);
                        rdr = cmd.ExecuteReader();

                        Console.WriteLine(cmd.Parameters["@DepName"].Value);

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

                public void spCall4()
                {
                    SqlDataReader rdr = null;

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("spStudentinCouse3", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter depname = new SqlParameter
                        {
                            ParameterName = "@StudentID",
                            SqlDbType = SqlDbType.Int,
                            Value = "3",
                            Direction = ParameterDirection.Input
                        };
                        SqlParameter returnval = new SqlParameter
                        {
                            ParameterName = "@Returnvaluee",
                            SqlDbType = SqlDbType.Int,

                            Direction = ParameterDirection.ReturnValue
                        };

                        cmd.Parameters.Add(depname);
                        cmd.Parameters.Add(returnval);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine((int)cmd.Parameters["@Returnvaluee"].Value);
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


            }
        }
    }
   }

