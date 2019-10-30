//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace ActionMethodsProject
//{
//    interface Interface2
//    {


//        void Methods();
//        void Create();
//    }
//    public class Product : Interface2
//    {
//        public void Methods()
//        {
//            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
// "Password=bizruntime@123;");
//            string query = @"CREATE TABLE dbo.Sample
//                (
//                    ID int IDENTITY(1,1) NOT NULL,
//                    Name nvarchar(50) NULL,
//                    Price nvarchar(50) NULL,
//                    Date datetime NULL,
//                    CONSTRAINT pk PRIMARY KEY (ID)
//                );";

//            SqlCommand cmd = new SqlCommand(query, con);
//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Table Created Successfully");
//            }
//            catch (SqlException e)
//            {
//                Console.WriteLine("Error Generated. Details: " + e.ToString());
//            }
//            finally
//            {
//                con.Close();

//                Console.ReadKey();
//            }
//        }
//        public void Create()
//        {
//            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
// "Password=bizruntime@123;");
           
//            string query = "INSERT INTO Sample (Name,Price,Date) VALUES('LED Screen','$120','27 January 2017')";
//            SqlCommand cmd = new SqlCommand(query, con);
//            try
//            {
//                con.Open();
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Records Inserted Successfully");
//            }
//            catch (SqlException e)
//            {
//                Console.WriteLine("Error Generated. Details: " + e.ToString());
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}
