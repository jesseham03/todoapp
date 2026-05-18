using System.Diagnostics;

bool isRunning = true;
TaskManager taskManager = new TaskManager();


while (isRunning)
{
    Console.WriteLine("Welcome to the Todo App");
    Console.WriteLine("choose an option and enter a number:");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Show tasks");
    Console.WriteLine("3. Complete task");
    Console.WriteLine("4. Delete task");
    Console.WriteLine("5. Exit");
    
    string commandinput = Console.ReadLine();
    string addinput = Console.ReadLine();
    switch (commandinput)
    {
        case "1":
            taskManager.AddTask(addinput);
            break;

    }
}
