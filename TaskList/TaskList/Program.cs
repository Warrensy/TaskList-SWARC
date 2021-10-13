using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskListClass ToDoList = new TaskListClass();
            bool DoNotStop = true;
            int TaskPriority;
            string TaskTitle;
            string TaskExtraInfo;
            while (DoNotStop)
            {
                Console.WriteLine("Enter new Task: ");
                TaskTitle = Console.ReadLine();
                Console.WriteLine("Description: ");
                TaskExtraInfo = Console.ReadLine();
                Console.WriteLine("Set A Priority: ");
                TaskPriority = Convert.ToInt32(Console.ReadLine());
                //TaskID = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
