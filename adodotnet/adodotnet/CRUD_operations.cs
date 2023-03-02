using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;

namespace adodotnet
{
    internal class CRUD_operations
    {
       /* class Program
        {
            SqlConnection conn;
            public Program()
            {
                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");
            }

            static void Main()
            {

                Program scd = new Program();
                Console.WriteLine();
                Console.WriteLine("categories before insert");
                Console.WriteLine("----------------------");

                scd.ReadData();

                scd.InsertData();

                Console.WriteLine();
                Console.WriteLine("categories after insert");
                Console.WriteLine("----------------------");

                scd.ReadData();

                scd.UpdateData();

                Console.WriteLine();
                Console.WriteLine("categories after update");
                Console.WriteLine("----------------------");

                scd.ReadData();

                scd.DeleteData();
                Console.WriteLine();
                Console.WriteLine("categories after delete");
                Console.WriteLine("----------------------");
                scd.ReadData();

                int numberOfRecords = scd.GetNumberOfRecords();
                Console.WriteLine();
                Console.WriteLine("number of records : " + numberOfRecords);

            }

            public void ReadData()
            {
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select CategoryName from Categories", conn);
                    
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0]);
                    }
                }
                finally
                {   //closing the reader object
                    if (rdr != null)
                    {
                        rdr.Close();
                    }

                    //closing the connection object
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
                    conn.Open();
                    string insertString = @"
                                        insert into Categories 
                                        (CategoryName,Description)
                                        values ('Miscellaneous','Whatever doesn''t fit elsewhere')";

                    SqlCommand cmd = new SqlCommand(insertString, conn);

                    cmd.ExecuteNonQuery();

                }
                finally
                {   
                    //closing the connection object
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
                    conn.Open();
                    string updateString = @"
                                        update Categories 
                                           set CategoryName='Other'
                                       
                                       where CategoryName= 'Miscellaneous' ";

                    SqlCommand cmd = new SqlCommand(updateString, conn);

                    cmd.ExecuteNonQuery();

                }
                finally
                {
                    //closing the connection object
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
                    conn.Open();
                    string deleteString = @"
                                        delete from Categories 
                                           where CategoryName='Other' ";
                                       
                                       

                    SqlCommand cmd = new SqlCommand(deleteString, conn);

                    cmd.ExecuteNonQuery();

                }
                finally
                {
                    //closing the connection object
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }


            }

            public int GetNumberOfRecords()
            {
                int count = -1;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from Categories", conn);

                    //call executescalar to send command
                    count=(int)cmd.ExecuteScalar();
                }
                finally
                {
                    if(conn!=null)
                    {
                        conn.Close();
                    }
                }
                return count;
            }
        }*/
    }
}
