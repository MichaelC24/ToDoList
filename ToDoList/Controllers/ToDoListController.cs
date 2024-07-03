using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Context;
using ToDoList.Controllers;
using ToDoList.Model;


namespace ToDoList.Controllers
{
    public class ToDoListController
    {
        private readonly Connection _context;

        public ToDoListController()
        {
            var context = new Connection();
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
        public ToDoListTable AddToDo(ToDoListTable todo)
        {

            todo.Status = "Active";
            todo.Priority = "Medium";
            todo.DueDate = DateTime.Now.AddDays(7);
            _context.ToDoLists.Add(todo);
            var rl = _context.SaveChanges();
            return (rl == 1) ? todo : null;
          
        }
        public bool StatusUpdate(int Id, string Status)
        {
            var found = _context.ToDoLists.Find(Id);
            if (found != null)
            {
                found.Status = Status;
                _context.Add(found);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
        public bool DateUpdate(int Id, DateTime DueDate)
        {
            var found = _context.ToDoLists.Find(Id);
            if (found != null)
            {
                found.DueDate = DueDate;
                _context.Add(found);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
        //public bool Completed(int Id, string Status)
        //{
        //    var ToDo = _context.ToDoLists.Find(Id);
        //    if (ToDo.Status != "Completed")
        //    {
        //        ToDo.Status = "Completed";
        //        _context.Add(ToDo);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;


        //}

    }
}



