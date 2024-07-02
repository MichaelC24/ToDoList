using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Context
{
    public class Connection
    {
        private string _connectionString { get; set; } = string.Empty;
        private SqlConnection? _sqlConnection { get; set; } = null;

        public SqlConnection? GetSqlConnection()
        {
            return _sqlConnection;
        }

        public void Open()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlConnection.Open();
            if (_sqlConnection.State != System.Data.ConnectionState.Open)
            {
                _sqlConnection = null;
                throw new Exception("Connections Failed");
            }
        }
        public void Close()
        {
            _sqlConnection?.Close();
        }
        public Connection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
