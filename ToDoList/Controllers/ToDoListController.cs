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
        public IEnumerable<ToDoListTable> GetAll()
        {
            var test = (from a in _context.ToDoLists
                        select a).ToList();
            return test;
            
        }
    }
}
