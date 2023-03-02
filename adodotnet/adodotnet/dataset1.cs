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
   /* class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=books;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from book", connection);

                DataSet ds = new DataSet();
                da.Fill(ds, "book");
                Console.WriteLine("Table Book");

                foreach (DataRow row in ds.Tables["book"].Rows)
                {

                    Console.WriteLine(row["id"] + ", " + row["title"] + ", " + row["author"] + ", " + row["published_date"] +
                    ", " + row["isbn"]);

                }
                SqlDataAdapter d = new SqlDataAdapter("select * from checkouts", connection);


                d.Fill(ds, "checkouts");
                Console.WriteLine();
                Console.WriteLine("Table Checkouts");

                foreach (DataRow row in ds.Tables["checkouts"].Rows)
                {

                    Console.WriteLine(row["id"] + ", " + row["user_id"] + ", " + row["book_id"] + ", " + row["checkout_date"] +
                    ", " + row["return_date"]);

                }

            }

            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }


        }
    }*/
}