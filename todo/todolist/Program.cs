using System;
using System.Collections.Generic;

namespace ToDoDSuka
{
    class Programm
    {
        struct Task
        {
            public int id;
            public string task;
            public string descriprion;

            public Task(int id, string task, string descriprion) : this()
            {
                this.id = id;
                this.task = task;
                this.descriprion = descriprion;
            }
            public void AddTask(int neededID)
            {
                Console.WriteLine("Task: ");
                task = Console.ReadLine();
                Console.WriteLine("Description: ");
                descriprion = Console.ReadLine();
                id = neededID;
            }
        }
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            Console.WriteLine("ToDoSukaList \n\nAdd | Delete | Show | Show all | Exit\n");

            bool exit = true;
            while (exit == true)
            {
                string tool = Console.ReadLine();
                if (tool == "Add")
                {
                    Task newtask = new Task();
                    int neededID;
                    if (tasks.Count < 1)
                    { neededID = 1; }
                    else
                    { int index = tasks.Count - 1; neededID = tasks[index].id + 1; }
                    newtask.AddTask(neededID);
                    tasks.Add(newtask);
                    Console.WriteLine($"The task was received \nTask number: {newtask.id} \n");
                }
                else if (tool == "Show")
                {
                    foreach (Task task in tasks)
                    {
                        Console.WriteLine($"{task.id}. {task.task} \n");
                    }
                }
                else if (tool == "Show pers")
                {
                    foreach (Task task in tasks)
                    {
                        Console.WriteLine($"{task.id}. {task.task} \n{task.descriprion} \n");
                    }
                }
                else if (tool == "Exit")
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Bastard, come on again \n");
                }

            }
        }
    }
}