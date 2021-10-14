using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class TaskCreater
    {
        public Task CreateNewTask()
        {
            Task tmp;
            Console.Write("Task-Name: ");
            string Title = Console.ReadLine();
            Console.Write("Task-Priority: ");
            int Priority = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Day (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month (1-12): ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year (20XX): ");
            int month = Convert.ToInt32(Console.ReadLine());
            DateTime _DueDate = new DateTime(year, month, day, 0, 0, 0);
            tmp = new Task(Priority, Title, _DueDate);
        return tmp;
        }
    }
}
