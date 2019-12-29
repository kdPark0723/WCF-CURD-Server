using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WCF_Server
{
    public class DataAccessor : IDataAccessor
    {
        static public DatabaseConnectionInfo currentConnection;

        DatabaseConnectionInfo connectionInfo;
        MySqlConnection connection;

        public DataAccessor() : this(currentConnection)
        {
        }

        public DataAccessor(DatabaseConnectionInfo connectionInfo)
        {
            this.connectionInfo = connectionInfo;

            string connctionString = connectionInfo.GetConnectionInfo();
            connection = new MySqlConnection(connctionString);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();

                throw ex;
            }
        }

        public DataSet GetData()
        {
            string query = "SELECT * FROM " + connectionInfo.GetTable();

            return ExcuteSelectQuery(query);
        }

        public void InsertData(string colNames, string colData)
        {
            string query = "INSERT INTO " + connectionInfo.GetTable() + "(" + colNames + ") VALUES (" + colData + ")";

            ExcuteNonQuery(query);
        }

        public void UpdateData(string cols, string keys)
        {
            string query = "UPDATE " + connectionInfo.GetTable() + " SET " + cols + " WHERE " + keys;

            ExcuteNonQuery(query);
        }

        public void DeleteData(string keys)
        {
            string query = "DELETE FROM " + connectionInfo.GetTable() + " WHERE " + keys;

            ExcuteNonQuery(query);
        }

        private DataSet ExcuteSelectQuery(string query)
        {
            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            connection.Close();

            return ds;
        }

        private void ExcuteNonQuery(string query)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
