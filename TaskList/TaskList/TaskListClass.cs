using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class TaskListClass : ITaskList
    {
        public TaskListClass()
        {
        }
        List<Task> TaskCollection = new List<Task>();

        public void AddTask(Task NewTask)
        {
            NewTask.ID = TaskCollection.Count;
            TaskCollection.Add(NewTask);
            Console.WriteLine("Task has been added to List.\n");
        }

        public void GetTask()
        {
            throw new NotImplementedException();
        }

        public void RemoveTaskByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
