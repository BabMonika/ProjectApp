using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNotesApp.Models
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompleted { get; set; }
    }
}

