using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class TaskListClass : ITaskList
    {
        public TaskListClass()
        {

        }
        List<Task> TaskCollection = new List<Task>();

        public void AddTask(Task NewTask)
        {
            NewTask.ID = TaskCollection.Count;
            TaskCollection.Add(NewTask);
            Console.WriteLine("Task has been added to List.");
        }

        public void RemoveTaskByID(int ID)
        {
            TaskCollection.RemoveAt(ID);
            Console.WriteLine("Task has been removed");
        }

        public void LoadTasks()
        {
            if(TaskCollection.Count > 0)
            {
                for(int i = 0; i < TaskCollection.Count; i++)
                {
                    Console.Write("\nTask " + i + ": " + TaskCollection[i].Title + " Date: " + TaskCollection[i]._DueDate.ToString("dd/MM/yyyy") + " Priority: " + TaskCollection[i].Priority);
                    if (TaskCollection[i]._DueDate <= DateTime.Now.Date)
                    {
                        Console.Write(" *Expired");
                    }
                }
            }
            else { Console.WriteLine("You don't have any Tasks."); }
        }
        public void LoadSingleTask(int i)
        {
            Console.Write("Task " + i + ": " + TaskCollection[i].Title + "  " + TaskCollection[i]._DueDate.ToString("dd/MM/yyyy") + " Priority: " + TaskCollection[i].Priority);
            if (TaskCollection[i]._DueDate <= DateTime.Now.Date)
            {
                Console.Write(" *Expired");
            }
            Console.WriteLine();
            TaskMenu(i);
        }
        public void TaskMenu(int i)
        {
            string Command;
            Console.WriteLine("Update [upt]");
            Console.WriteLine("Delete [del]");
            Console.WriteLine("Set Priority [set]");
            Console.WriteLine("Go Back [b]");
            Console.Write("Enter Command: ");
            Command = Console.ReadLine();
            if(Command == "upt")
            {
                Console.WriteLine("Set new Name: ");
                TaskCollection[i].Title = Console.ReadLine();
                Console.WriteLine("Set new Date (dd/mm/yyyy): ");
                TaskCollection[i]._DueDate = DateTime.Parse(Console.ReadLine());
            }
            else if(Command == "del")
            {
                RemoveTaskByID(i);
            }
            else if(Command == "set")
            {
                Console.WriteLine("Set new Priority: ");
                TaskCollection[i].Priority = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void SortTasksByPriority(ref TaskListClass ToDoList)
        {
            TaskListClass SortedList = new TaskListClass();
            SortedList.TaskCollection = ToDoList.TaskCollection.OrderBy(TaskCollection => TaskCollection.Priority).ToList();
            SortedList.LoadTasks();
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        public void SortTasksByDate(ref TaskListClass ToDoList)
        {
            TaskListClass SortedList = new TaskListClass();
            SortedList.TaskCollection = ToDoList.TaskCollection.OrderBy(TaskCollection => TaskCollection._DueDate).ToList();
            SortedList.LoadTasks();
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

    }
}
