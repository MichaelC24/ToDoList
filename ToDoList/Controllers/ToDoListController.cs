using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ToDoList.Context;
using ToDoList.Model;

namespace ToDoList.Controllers
{
    public class ToDoListController 
    {
        private readonly Connection _context;

        public ToDoListController(Connection context)
        {
            _context = context;
        }
        public List<ToDoListTable> GetAll()
        {
            var test = (from a in _context.ToDoLists
                        where a.Status != "Completed"
                        orderby a.Priority ascending
                        select a).ToList();
            return test;

        }
        public bool Add(ToDoListTable todo)
        {
            
            todo.Status = "Active";
            todo.Priority = "Medium";
            todo.DueDate = DateTime.Now.AddDays(7);
            _context.ToDoLists.Add(todo);
            var rl = _context.SaveChanges();
            if (rl == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        

    }
}
