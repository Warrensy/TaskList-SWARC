using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Menu
    {
        public void OptionCall(ref int CurrentChoice, ref TaskListClass ToDoList)
        {
            TaskCreater creater = new TaskCreater();
            switch(CurrentChoice)
            {
                case 0:
                    ToDoList.AddTask(creater.CreateNewTask());
                    break;
                case 1:
                    Console.WriteLine("\nSort by Date [date]");
                    Console.WriteLine("Sort by Priority [pri]");
                    Console.Write(" : ");
                    string tmp = Console.ReadLine();
                    if (tmp == "date")
                    {
                        ToDoList.SortTasksByDate(ref ToDoList);
                    }
                    else if(tmp == "pri")
                    {
                        ToDoList.SortTasksByPriority(ref ToDoList);
                    }
                    break;
                case 2:
                    ToDoList.LoadTasks();
                    SelectTaskByNumber(ref ToDoList);
                    break;
            }
        }
        public void MainMenu(ref int CurrentChoice, ref bool Quit, ref TaskListClass ToDoList)
        {
            Console.Clear();
            Console.WriteLine("Tasklist-Manager 1.0\n");
            Console.WriteLine("Use arrow keys for up and down navigation");
            Console.WriteLine("Press enter to select option or [q] to quit program.\n");
            Console.Write("Add Task");
            if (CurrentChoice == 0) Console.WriteLine(" <-");
            else Console.WriteLine("");
            Console.Write("Set Filter");
            if(CurrentChoice == 1) Console.WriteLine(" <-");
            else Console.WriteLine("");
            Console.Write("Show Task List");
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
                    OptionCall(ref CurrentChoice, ref ToDoList);
                    break;
                case ConsoleKey.Q:
                    Quit = true;
                    break;
                default:
                    break;
            }
        }
        public void SelectTaskByNumber(ref TaskListClass ToDoList)
        {
            Console.Write("\nEnter task number: ");
            int SelectedTask = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            ToDoList.LoadSingleTask(SelectedTask);
        }
    }
}
