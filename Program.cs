using System.Diagnostics;

bool isRunning = true;
TaskManager taskManager = new TaskManager();
Console.WriteLine("Welcome to the Todo App");

while (isRunning)
{   
    Console.WriteLine("What do you want to do now?");
    Console.WriteLine("choose an option and enter a number:");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Show tasks");
    Console.WriteLine("3. Complete task");
    Console.WriteLine("4. Delete task");
    Console.WriteLine("5. Exit");
    string commandinput = Console.ReadLine();

    switch (commandinput)
    {
        case "1":
            Console.WriteLine("Enter the task title:");
            string addinput = Console.ReadLine();
            taskManager.AddTask(addinput);
            break;
        case "2":
            taskManager.ShowTasks();
            break;
        case "3":
            Console.WriteLine("Enter the task title:");
            string completeinput = Console.ReadLine();
            taskManager.CompleteTask(completeinput);
            break;
        case "4":
            Console.WriteLine("Enter the task title:");
            string deleteinput = Console.ReadLine();
            taskManager.DeleteTask(deleteinput);
            break;
        case "5":
            isRunning = false;
            break;
    }
    
}
