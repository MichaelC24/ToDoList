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
        //public IQueryable<ToDoListTable> GetAll()
        //{
        //    var test = (from a in _context.ToDoLists
        //                select a).ToList() ;
        //    return test;

        //}
        public bool Add(ToDoListTable todo)
        {
            
            todo.Status = "Active";
            todo.Priority = "Medium";
            todo.DueDate = DateTime.Now.AddDays(7);
            _context.Add(todo);
            _context.SaveChanges();
            if (_context.SaveChanges() == 1)
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
