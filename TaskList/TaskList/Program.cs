using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Program
    {
        //void Navigate(int CurrentChoice, int Line)
        //{
        //    if (CurrentChoice == Line) Console.WriteLine(" <-");
        //    else Console.WriteLine("");
        //}
        static void Main(string[] args)
        {
            var test = Console.ReadKey();
            Console.WriteLine(test);
            TaskListClass ToDoList = new TaskListClass();
            bool Quit = false;
            int CurrentChoice = 0;
            int TaskPriority;
            string TaskTitle;
            string TaskExtraInfo;
            
            while (!Quit)
            {
                Console.Clear();
                Console.WriteLine("Tasklist-Manager 1.0");
                Console.Write("Add Task");
                if (CurrentChoice == 0) Console.WriteLine(" <-");
                else Console.WriteLine("");
                Console.Write("Set Filter");
                if(CurrentChoice == 1) Console.WriteLine(" <-");
                else Console.WriteLine("");
                Console.Write("Enter new Task");
                if(CurrentChoice == 2) Console.WriteLine(" <-");
                else Console.WriteLine("");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if(CurrentChoice > 0) CurrentChoice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if(CurrentChoice < 2) CurrentChoice++;
                        break;
                    case ConsoleKey.Enter:

                    case ConsoleKey.Q:
                        Quit = true;
                        break;
                    default:
                        continue;
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
}
