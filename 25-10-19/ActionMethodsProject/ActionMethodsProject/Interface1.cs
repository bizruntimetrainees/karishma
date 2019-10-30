//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace ActionMethodsProject
//{
//    interface Interface1
//    {
//        void Methods();
//        void Create();
//    }
//    public class Emptable : Interface1
//    {
//        public void Methods()
//        {
//            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
// "Password=bizruntime@123;");
//            string query =
//            @" CREATE TABLE dbo.EMPTABLE9
//                       (
//                           ID int IDENTITY(1,1) NOT NULL,
//                           ENAME nvarchar(50) NULL,
//                           JOB nvarchar(20),
//                           MGR int NULL,
//                           HIREDATE Date NULL,
//                          SAL numeric(7,2) NULL,
//                          COMM numeric(7,2) NULL,
//                         CONSTRAINT oid PRIMARY KEY (ID)
//                       );";
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
//            //int tempData = 0678;
//            SqlConnection con = new SqlConnection(@"Data Source=106.51.126.111;" + "Initial Catalog=karishma;" + "User id=sa;" +
// "Password=bizruntime@123;");
//            string query = "INSERT INTO EMPTABLE9 (ENAME,JOB,MGR,HIREDATE,COMM,SAL) VALUES('KARISHMA','DEVELOPER','0678','03 OCTOBER 2019',5000.00,20000.75)";
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



