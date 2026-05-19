using System.Diagnostics;

bool isRunning = true;
List<TodoTask> loadedTasks = StorageService.LoadTasks("tasks.json");
TaskManager taskManager = new TaskManager(loadedTasks);
Console.WriteLine("Welcome to the Todo App");

while (isRunning)
{   
    Console.WriteLine("choose an option and enter a number:");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Complete task");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("4. Exit");
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
            isRunning = false;
            break;
    }
    taskManager.ShowTasks();
}
