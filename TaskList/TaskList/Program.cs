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
            var test = Console.ReadKey();
            Console.WriteLine(test);
            TaskListClass ToDoList = new TaskListClass();
            bool Quit = false;
            int CurrentChoice = 0;
            int TaskPriority;
            string TaskTitle;
            Menu menu = new Menu();

            while (!Quit)
            {
                Quit = menu.MainMenu(CurrentChoice, 1 , Quit, TaskListClass ToDoList);
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
