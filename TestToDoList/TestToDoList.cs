using ToDoList;
using ToDoList.Context;
using ToDoList.Controllers;
using ToDoList.Model;

namespace TestToDoList
{
    public class TestToDoList
    {
        ToDoListTable todo = default!;
        ToDoListController controller = default!;
        Connection _context = default!;


        public TestToDoList()
        {
            todo = new ToDoListTable();
            controller = new ToDoListController();

        }
        [Fact]
        public void TestAdd()
        {

           var todo1 = controller.AddToDo(todo);
            Assert.Equal("Active", todo.Status);
            Assert.Equal("Medium", todo.Priority);
            //Assert.True(todo1.id == _context.ToDoLists.Count());
        }
        [Fact]
        public void TestGetAll()
        {
            var x = controller.GetAll();
            Assert.Equal(x.Count(),_context.ToDoLists.Count());
        }
    }
}