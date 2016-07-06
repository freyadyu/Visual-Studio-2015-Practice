using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Remoting;
using System.Data.SqlClient;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {

        public int insertData(Student student)
        {
            int rowEffected = 0;
            try
            {
                string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                string cmdTxt = "INSERT INTO StudentDetails(StudentID, StudentName, StudentGender) VALUES(@StudID, @StudName, @StudGender)";
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand(cmdTxt, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@StudID", student.StudID);
                        cmd.Parameters.AddWithValue("@StudName", student.StudName);
                        cmd.Parameters.AddWithValue("@StudGender", student.StudGender);

                        rowEffected = cmd.ExecuteNonQuery();

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            sqlCon.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                Console.WriteLine(rowEffected);
            }

            return rowEffected;
        }
    }
}
