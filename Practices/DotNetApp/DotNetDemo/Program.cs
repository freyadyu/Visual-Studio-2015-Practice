using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string cmdTxt = "DELETE Student where Name like '%Dian%'; SELECT COUNT(*) FROM Student WHERE Name like '%d%';";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {
                    var deletedID = Convert.ToInt32(cmd.ExecuteScalar()); //returns the first column of the first row
                    // execute all the query, but just show the last query affected rows #

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }

            Console.ReadLine();

        } // end of main

        public void SQLExecuteScalarMultiQuery()
        {
            string conStr = "";
            string cmdTxt = ""; //"DELETE Student where Name = 'Lucy'; SELECT COUNT(*) FROM Student WHERE Name = 'Dian';";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {
                    var deletedID = Convert.ToInt32(cmd.ExecuteScalar()); //returns the first column of the first row
                    // execute all the query, but just show the last query affected rows #

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        public void SQLMultiExecuteNonQuery()
        {
            string conStr = "";
            string cmdTxt = ""; 
            //"Insert into student (Id, Name) Values(5,'Lucy')" + "Update Student set Name = 'Dian' where Name = 'Freya'";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {
                    var rowsEffected = cmd.ExecuteNonQuery(); //returns the first column of the first row

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        public void SQLExecuteScalar()
        {
            string conStr = "";
            string cmdTxt = "";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {
                    var newStudentId = Convert.ToInt32(cmd.ExecuteScalar()); //returns the first column of the first row

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        public void SQLExecuteNonQuery()
        {
            string conStr = "";
            string cmdTxt = "";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {

                    var rowEffected = cmd.ExecuteNonQuery(); //nonQuery's result is the # of rows affected

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        public void SQLDataReaderStudent()
        {
            string conStr = "";
            string cmdTxt = "";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader()) //exec data reader
                    {
                        while (dr.Read()) //Read next row
                        {
                            var kk = Convert.ToInt32(dr["Id"]);
                            var Name = Convert.ToString(dr["Name"]);
                        }
                        //dr.NextResult ==> read next query in cmdTxt
                    }

                }

                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }

            }
        }


    }
}
