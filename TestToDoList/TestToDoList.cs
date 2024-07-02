using ToDoList;
using ToDoList.Context;
using ToDoList.Controllers;
using ToDoList.Model;

namespace TestToDoList
{
    public class TestToDoList
    {
        ToDoListTable todo = new ToDoListTable();
        ToDoListController controller = default!;
        Connection _context = default!;

        [Fact]
        public void Test1()
        {
            todo = new ToDoListTable();
        }
        [Fact]
        public void TestAdd()
        {
            var newTodo = new ToDoListTable() {id = 0, DueDate = new DateTime(2024,7,2), Priority = "", Status = "", Description = "New test"};
            controller.Add(newTodo);
            var rl = _context.ToDoLists.Find(newTodo.id);
            Assert.True(rl != null);

        }
    }
}