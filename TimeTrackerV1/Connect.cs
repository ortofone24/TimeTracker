using System.Data;
using System.Data.SqlClient;

namespace TimeTrackerV1
{
    class Connect
    {
        private SqlConnection connection = new SqlConnection(***);

        public SqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
