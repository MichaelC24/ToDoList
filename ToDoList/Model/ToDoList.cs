using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    internal class ToDoList
    {
        public int id {  get; set; }
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; } = DateTime.MinValue;
        [StringLength(30)]
        public string Status { get; set; } = "Active";
        [StringLength(30)]
        public string Priority { get; set; } = "Medium";
    }
}
