using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testLiveCoding.Model
{
    public class ToDoItem
    {
        public long ID { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public string EventStatus { get; set; }
    }
}
