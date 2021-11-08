using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;

namespace TestProject1
{
    public class Tests
    {
        static SqlConnection ConnectToDB()
        {
            string cs = @"Server=naveenpracticesql.database.windows.net;User Id=naveenkk;Password=naveen@123;Database=JoesPizzaDB;Trusted_Connection=False;Encrypt=True;";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        public static DataRow GetRowById( int id)
        {
            string query = "SELECT * FROM orderdetails WHERE orderid = " + id;

            SqlDataAdapter da = new SqlDataAdapter(query, ConnectToDB());
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0];
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int id = 70755481;
            DataRow dt = GetRowById(id);
            int expectedCourse = 340;
            Assert.AreEqual(expectedCourse,dt[2]);
        }
        [Test]
        public void Test2()
        {
            int id = 70755481;
            DataRow dt = GetRowById(id);
            int expectedCourse = 340;
            Assert.AreEqual(expectedCourse, dt[2]);
        }
    }
}