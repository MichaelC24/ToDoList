using Microsoft.Data.SqlClient;
using ToDoList.Context;
using ToDoList.Controllers;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new Connection();
            var controller = new ToDoListController(_context);

            


            //Console.WriteLine( test.GetAll().Id);
            
            
        }
    }
}
