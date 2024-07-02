using Microsoft.Data.SqlClient;
using ToDoList.Context;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connStr = "Server = localhost\\sqlexpress01;database=ToDoList;trusted_connection=true;trustServerCertificate=true;";
            Connection connection = new Connection(connStr);    
        }
    }
}
