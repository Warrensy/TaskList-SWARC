using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class Task : ITask
    {
        public Task(int TaskPriority, string TaskTitle, DateTime DueDate)
        {
            _DueDate = DueDate;
            Priority = TaskPriority;
            Title = TaskTitle;
        }
        DateTime _DueDate;
        public int Priority { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public void UpdateTask()
        {
            throw new NotImplementedException();
        }
    }
}
