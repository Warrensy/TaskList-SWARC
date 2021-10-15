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
            bool Quit = false;
            int CurrentChoice = 0;
            TaskListClass ToDoList = new TaskListClass();
            Menu menu = new Menu();
            Database TaskData = new Database(ref ToDoList);
            while (!Quit)
            {
                menu.MainMenu(ref CurrentChoice, ref Quit, ref ToDoList);
            }
        }
    }
}
