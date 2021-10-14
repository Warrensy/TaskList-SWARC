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
            int Priority = Convert.ToInt32(Console.ReadLine());
            int ID = Convert.ToInt32(Console.ReadLine());
            string Title = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime _DueDate = new DateTime(year, month, day);
            tmp = new Task(Priority, ID, Title, _DueDate);
        return tmp;
        }
    }
}
