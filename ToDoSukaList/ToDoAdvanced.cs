using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
            string path = @"C:\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            List<Task> tasks = new List<Task>();
            Console.WriteLine("ToDoSukaList \n\nAdd | Delete | Show | Details | Exit\n");

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
                else if (tool == "Details")
                {
                    Console.WriteLine("Enter number of task fow show details");
                    int searchID = Convert.ToInt32(Console.ReadLine());
                    Task foundTask = tasks.Find(item => item.id == searchID);
                    Console.WriteLine($"{foundTask.task} \n{foundTask.descriprion}\n");
                }
                else if (tool == "Delete")
                {                                        
                    Console.WriteLine("Enter number of task to delite");
                    int searchID = Convert.ToInt32(Console.ReadLine());
                    Task foundTask = tasks.Find(item => item.id == searchID);
                    tasks.Remove(foundTask);
                    Console.WriteLine($"Task {foundTask.task} was deleted");
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
