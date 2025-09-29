using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the to do list.");
            List<string> tasklist = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remoe a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program");
                Console.WriteLine(" ");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter the task you would like added to the list");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine($"Task {task} added to the list.");

                }
                else if (option == "2")
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + " : " + tasklist[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);

                }
                else if (option == "3")
                {
                    Console.WriteLine("Current task in the list :");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);

                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");

                }
                else
                {
                    Console.WriteLine("Invalid Option, please try again.");
                }
                
            }
        }
    }
}
