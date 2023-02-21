using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class ConnSingleton
    {
        private static ConnSingleton dbInstance;
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=127.0.0.1;database=urfetdb;User id=urfet;Password=123123;");

        private ConnSingleton()
        {
        }

        private static ConnSingleton getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new ConnSingleton();
            }
            return dbInstance;
        }

        public SqlConnection GetDBConnection()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
            }
            finally
            {
            }

            return conn;
        }
    }
}
