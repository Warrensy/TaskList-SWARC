using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class Task : ITask
    {
        public Task(int TaskPriority, int TaskID, string TaskTitle, string TaskExtraInfo)
        {
            Priority = TaskPriority;
            ID = TaskID;
            Title = TaskTitle;
            ExtraInfo = TaskExtraInfo;
        }

        public int Priority { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string ExtraInfo { get; set; }

        public void UpdateTask()
        {
            throw new NotImplementedException();
        }
    }
}
