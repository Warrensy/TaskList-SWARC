using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    interface ITaskList
    {
        void RemoveTaskByID(int ID);
        void AddTask(Task NewTask);
        void LoadTasks();
    }
}
