using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList.Context
{
    public class Connection : DbContext
    {

        public DbSet<ToDoListTable> ToDoLists { get; set; } = default!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\sqlexpress01;database=ToDoList;trusted_connection=true;trustServerCertificate=true;");
        }

    }
}
