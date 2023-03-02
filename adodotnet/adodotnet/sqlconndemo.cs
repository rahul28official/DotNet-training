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
    internal class sqlconndemo
    {
        /*class Program
        {
            static void Main()
            {  
                string  connectionstring = 
                        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

                //provide the query string with a parameter placeholdeer
                string querystring = @"select  ProductId,UnitPrice,ProductName from dbo.products 
                            where UnitPrice > @pricePoint
                                order by UnitPrice desc";

                //specify the parameter value
                int paramvalue = 5;


                //create and open the connection in a using block. this ensures all the resources will be closed and 
                //disposed when the code exists

                using (SqlConnection connection = new SqlConnection(connectionstring))

                {   //create the command and parameter objects
                    SqlCommand command = new SqlCommand(querystring, connection);
                    command.Parameters.AddWithValue("@pricePoint", paramvalue);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);

                        }
                        reader.Close();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadLine();
                }  
            }
        }*/
    }
}
