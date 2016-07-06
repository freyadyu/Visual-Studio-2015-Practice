using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Search.Model;
using System.Data.SqlClient;

namespace Search.Data
{
    public class Dbhelper
    {

        public string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int searchByID(Index index)
        {
            int ID = index.id;
            
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand("SearchIndex", sqlCon))
                    {


                        //create store Proc to insert data in the user table w/ 2 parameters username and email
                        //return output --> Id parameter
                        //ADO.net here

                        //Output
                        
                        //2 parameter input
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = index.id;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //sql cmd executeNonQuery
                        cmd.ExecuteNonQuery();

                        if (sqlCon.State == ConnectionState.Open)
                        {
                            sqlCon.Close();
                        }
                    }
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally //clean the data not for return
            {

            }

            return ID;
        }

    }
}
