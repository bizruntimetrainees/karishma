using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ActionMethodsProject
{
    class Dropclass
    {
       public void Droptable()
        {
            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
     "Password=bizruntime@123;");
            string query =
              @"DROP TABLE Sample";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Deleted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
        public void Parameterized()
        {
            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
     "Password=bizruntime@123;");
            //Replaced Parameters with Value
            string query = "INSERT INTO EMPTABLE9 (ENAME,JOB,MGR,HIREDATE,COMM,SAL) VALUES('RAJESH','DEVELOPER',2352,'27 January 2016',75000,100000)";
            SqlCommand cmd = new SqlCommand(query, con);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@ENAME", "LOKESH");
            cmd.Parameters.AddWithValue("@JOB", "DEVELOPER");
            cmd.Parameters.AddWithValue("@MGR", 0378);
            cmd.Parameters.AddWithValue("@HIREDATE", "03 May 2019");
            cmd.Parameters.AddWithValue("@COMM", 4000);
            cmd.Parameters.AddWithValue("@SAL", 20000);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

    }

}
