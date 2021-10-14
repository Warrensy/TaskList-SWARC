using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Menu
    {
        public void OptionCall(int CurrentChoice)
        {
            TaskCreater creater = new TaskCreater();

            switch(CurrentChoice)
            {
                case 0:
                    ToDoList.AddTask(creater.CreateNewTask());
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
        public bool MainMenu(int CurrentChoice, int Line, bool Quit, TaskListClass ToDoList)
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
                    if(CurrentChoice< 2) CurrentChoice++;
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Q:
                    Quit = true;
                    break;
                default:
                    break;
            }
        return Quit;
        }
}
}
