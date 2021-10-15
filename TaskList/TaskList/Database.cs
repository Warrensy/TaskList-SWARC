using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Database
    {
        public Database(ref TaskListClass ToDoList)
        {
            FillDatabase(ref ToDoList);
        }
        public void FillDatabase(ref TaskListClass ToDoList)
        {
            DateTime date1 = DateTime.Parse("11/12/2020");
            Task one = new Task(2, "Book Hotel", date1);
            ToDoList.AddTask(one);

            DateTime date2 = DateTime.Parse("22/06/2021");
            Task two = new Task(5, "Call Mother", date2);
            ToDoList.AddTask(two);
            
            DateTime date3 = DateTime.Parse("01/12/2021");
            Task three = new Task(1, "Pay Gas Bill", date3);
            ToDoList.AddTask(three);
            
            DateTime date4 = DateTime.Parse("11/12/2020");
            Task four = new Task(3, "Birthday Jim", date1);
            ToDoList.AddTask(four);
            
            DateTime date5 = DateTime.Parse("23/10/2021");
            Task five = new Task(1, "Car Dealer Meeting", date1);
            ToDoList.AddTask(four);
        }
    }
}
