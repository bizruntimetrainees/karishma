using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlQueries
{
    class Program
    {
        static void Main(string[] args)
        {




 
           string ConString = @"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
 "Password=bizruntime@123;";
                SqlConnection con = new SqlConnection(ConString);
                string querystring = "Select * from EMPLOYEES";
                con.Open();
                SqlCommand cmd = new SqlCommand(querystring, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "   " + reader[1].ToString() + "   " + reader[2].ToString() + "   " + reader[3].ToString() + "   " + reader[4].ToString());
                
                }
            Console.ReadKey();
        }
    }
    }

