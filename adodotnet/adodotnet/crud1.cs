using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace adodotnet
{
    internal class crud1
    {
       /* class Program
        {
            SqlConnection conn;
            public Program()
            {
                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=practice;Integrated Security=SSPI");
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

                Console.WriteLine();
                Console.WriteLine("calling the created sp");
                Console.WriteLine("----------------------");
                scd.getsp();

                Console.WriteLine();
                Console.WriteLine("ordering the data ");
                Console.WriteLine("----------------------");
                scd.order();

                Console.WriteLine();
                Console.WriteLine("ordering the data in descending ");
                Console.WriteLine("----------------------");
                scd.orderdesc();


                Console.WriteLine();
                Console.WriteLine("grouping the data");
                Console.WriteLine("----------------------");
                scd.grouping();



            }
            public void ReadData()
            {
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select name,description from products", conn);

                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + "\t" + rdr[1]);
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
                                        insert into products 
                                        (name,description)
                                        values ('Rahul Shaw','tablet 7inch')";

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
                                        update products 
                                           set name='Rajesh Arora'
                                       
                                       where name= 'Rahul Shaw' ";

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
                                        delete from products
                                           where name='Rajesh Arora' ";



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
                    SqlCommand cmd = new SqlCommand("select count(*) from products", conn);

                    //call executescalar to send command
                    count = (int)cmd.ExecuteScalar();
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
                return count;
            }
            public void getsp()
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spGetOrderDetails", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlDataReader sqd=cmd.ExecuteReader();

                    while(sqd.Read())
                    {
                        Console.WriteLine(sqd["orderId"]+"\t"+ sqd["customerId"] + "\t" + sqd["productId"] + "\t" + sqd["quantity"] + "\t" + sqd["lineNumber"] + "\t" + sqd["dateOrdered"] + "\t" + sqd["dateRequired"]);
                    }
                   
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

            public void order()
            {
                SqlDataReader rdr = null; 
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select name,description from products order by name ", conn);
                    rdr= cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + "\t" + rdr[1]);
                    }

                }
                finally
                    {
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

            public void orderdesc()
            {
                SqlDataReader rdr = null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select name,description from products order by name desc ", conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + "\t" + rdr[1]);
                    }

                }
                finally
                {
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

            public void grouping()
            { SqlDataReader rdr= null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(orderId), quantity  from orderDetails group by quantity ", conn);
                    rdr= cmd.ExecuteReader();
                    while ( rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + "\t" +  rdr[1]);
                    }


                }
                finally
                {
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
        }*/
    }
}

