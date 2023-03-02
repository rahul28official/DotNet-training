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
    internal class demo1
    {
       /* class Program
        {
            static void Main()
            {   //1. Instantiating the connection using connection object and passing connection url
                SqlConnection conn = new SqlConnection(
                        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=SSPI");

                //creating reader object for reading data from database to c#
                SqlDataReader rdr = null;
                try
                {   //opening the connection
                    conn.Open();

                    //command object for passing the connection and query
                    SqlCommand cmd = new SqlCommand("select * from employee", conn);

                    //reading query results using reader object and execute reader method
                    rdr = cmd.ExecuteReader();

                    //printing the customer id of each record that is the first column rdr[1]
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
        }*/
    }
}
