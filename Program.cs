using System.Diagnostics;
//in this file we handle user input and main loop of program

bool isRunning = true;
List<TodoTask> loadedTasks = StorageService.LoadTasks("tasks.json");
TaskManager taskManager = new TaskManager(loadedTasks);
Console.WriteLine("Welcome to the Todo App");

//main loop
while (isRunning)
{   
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Complete task");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("4. Edit task");
    Console.WriteLine("5. Exit");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Here are your current tasks:");
    taskManager.ShowTasks();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("choose an option and enter a number:");
    string commandinput = Console.ReadLine() ?? "";

    switch (commandinput)
    {
        case "1":
            Console.WriteLine("Enter the task title:");
            string addinput = Console.ReadLine() ?? "";
            taskManager.AddTask(addinput);
            break;
        case "2":
            Console.WriteLine("Enter the task number to complete:");
            string completeinput = Console.ReadLine() ?? "";
            taskManager.CompleteTask(completeinput);
            break;
        case "3":
            Console.WriteLine("Enter the task number to delete:");
            string deleteinput = Console.ReadLine() ?? "";
            taskManager.DeleteTask(deleteinput);
            break;
        case "4":
            Console.WriteLine("Enter the task number to edit:");
            string editinput = Console.ReadLine() ?? "";
            Console.WriteLine("Enter the new task title:");
            string newtitle = Console.ReadLine() ?? "";
            taskManager.EditTask(editinput, newtitle);
            break;
        case "5":
            isRunning = false;
            break;
    }
}