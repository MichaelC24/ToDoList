using Microsoft.Data.SqlClient;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = "Server = localhost\\sqlexpress01;database=SalesDb;trusted_connection=true;trustServerCertificate=true;";
            Connection connection = new Connection(connStr);    
        }
    }
}
