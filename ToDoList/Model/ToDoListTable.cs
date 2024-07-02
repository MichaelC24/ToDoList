using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class ToDoListTable
    {
        public int id {  get; set; }
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; } = DateTime.MinValue;
        [StringLength(30)]
        public string Status { get; set; } = string.Empty;//"Active";
        [StringLength(30)]
        public string Priority { get; set; } = string.Empty;//"Medium";
    }
}
