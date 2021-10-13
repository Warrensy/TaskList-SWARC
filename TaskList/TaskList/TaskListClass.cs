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
            TaskIDCounter = 0;
        }
        int TaskIDCounter;
        List<Task> Tasks = new List<Task>();

        public void AddTask(Task NewTask)
        {
            NewTask.ID = TaskIDCounter;
            TaskIDCounter++;
            Tasks.Add(NewTask);
            Console.WriteLine("Task has been added to To-Do List.\n");
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
