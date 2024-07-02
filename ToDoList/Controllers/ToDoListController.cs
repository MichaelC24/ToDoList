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
        public bool StatusUpdate(int Id, string Status) {
            var found = _context.ToDoLists.Find(Id);
            if (found != null) {
                found.Status = Status;
                _context.Add(found);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
            public bool DateUpdate(int Id, DateTime DueDate) {
                var found = _context.ToDoLists.Find(Id);
                if (found != null) {
                    found.DueDate = DueDate;
                    _context.Add(found);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
        public bool Completed(int Id, string Status) {
            var ToDo = _context.ToDoLists.Find(Id);
            if (ToDo.Status != "Completed") {
                ToDo.Status = "Completed";
                _context.Add(ToDo);
                _context.SaveChanges();
                return true; }
            return false;


        }
          
        }
        }

   

