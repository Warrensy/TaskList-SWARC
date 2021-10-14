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
            bool Quit = false;
            int CurrentChoice = 0;
            int Line = 0;
            Menu menu = new Menu();

            while (!Quit)
            {
                menu.MainMenu(ref CurrentChoice, ref Line , ref Quit, ref ToDoList);
            }
                //TaskTitle = Console.ReadLine();
                //Console.WriteLine("Description: ");
                //TaskExtraInfo = Console.ReadLine();
                //Console.WriteLine("Set A Priority: ");
                //TaskPriority = Convert.ToInt32(Console.ReadLine());
                //TaskID = Convert.ToInt32(Console.ReadLine());
        }
    }
}
