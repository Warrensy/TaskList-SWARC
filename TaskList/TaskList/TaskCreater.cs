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
            Console.Write("Enter Date dd/mm/yyyy: ");
            DateTime Date = DateTime.Parse(Console.ReadLine());
            tmp = new Task(Priority, Title, Date);
        return tmp;
        }
    }
}
