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
    internal class top5items
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
                Program scd=new Program();
                Console.WriteLine();
                Console.WriteLine("Top 5 items from northwind");
                Console.WriteLine("----------------------");
                scd.read();

            }
            public void read()
            {
                SqlDataReader rdr = null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select top 5 ProductName from products order by UnitPrice desc", conn);
                    rdr=cmd.ExecuteReader();
                    while(rdr.Read())
                    {
                        Console.WriteLine(rdr[0]);
                    }
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if(conn!=null)
                    {
                        conn.Close();
                    }
                }
            }
        }*/
    }
}
