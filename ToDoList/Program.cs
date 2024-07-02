using Microsoft.Data.SqlClient;
using ToDoList.Context;
using ToDoList.Controllers;
using ToDoList.Model;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new Connection();
            var controller = new ToDoListController(_context);
            var todo = new ToDoListTable() { id = 0, Description = "test2", DueDate = new DateTime(2024, 7, 2), Priority = "", Status = "" };

            Console.WriteLine( controller.Add(todo));
            var x = controller.GetAll();

            foreach (var item in x)
            {
                Console.WriteLine($"ID: {item.id} | Description: {item.Description} | Date: {item.DueDate} | Status: {item.Status} | Priority: {item.Priority} ");
            }

            //Console.WriteLine( test.GetAll().Id);
            
            
        }
    }
}
