using System.Runtime.CompilerServices;

//in this class all the functions of tasks will be handled, such as adding, showing, completing and deleting tasks. 
class TaskManager
{
    //first we create a list, where we store our tasks
    private List<TodoTask> tasks = new List<TodoTask>();

    //constructor that we use to load in the tasks from json file
    public TaskManager(List<TodoTask> loadedTasks)
    {
        tasks = loadedTasks;
    }

    //method to add a task to the list we created. Also stores the list in a json file after
    public void AddTask(string title, string priorityInput)
    {
        if(string.IsNullOrWhiteSpace(title) == false)
        {
            Priority priority = Priority.Medium;
            switch (priorityInput.ToLower())
            {
                case "low":
                    priority = Priority.Low;
                    break;
                case "medium":
                    priority = Priority.Medium;
                    break;
                case "high": 
                    priority = Priority.High;
                    break;
            }
            tasks.Add(new TodoTask { Title = title, IsCompleted = false, Priority = priority});
            StorageService.SaveTasks(tasks, "tasks.json");
        }
        else
        {
            Console.WriteLine("Task title cannot be empty.");
        }
    }

    //method to show the tasks in the list, using index 
    public void ShowTasks()
    {
        if(tasks.Count != 0)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
            var task = tasks[i];
            Console.WriteLine($"{i + 1}. {task.Title} - {(task.IsCompleted ? "completed" : "not completed")} [{task.Priority}]");
            }
        }
        else
        {
            Console.WriteLine("No tasks yet.");
        }
        
    }

    //method to mark a task as completed, using index. Also stores the list in a json file after
    public void CompleteTask(string index)
    {
        if(string.IsNullOrWhiteSpace(index) == false)
        {
            if(TryIndex(index, out int taskIndex))
            {
                tasks[taskIndex -1].IsCompleted = true;
                StorageService.SaveTasks(tasks, "tasks.json");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }
        else
        {
            Console.WriteLine("Task index cannot be empty.");
        }
    }

    //method to delete a task, using index. Also stores the list in a json file after
    public void DeleteTask(string index)
    {
        if(string.IsNullOrWhiteSpace(index) == false)
        {
            if(TryIndex(index, out int taskIndex))
            {
                tasks.RemoveAt(taskIndex -1);
                StorageService.SaveTasks(tasks, "tasks.json");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }
        else
        {
            Console.WriteLine("Task index cannot be empty.");
        }
    }

    public void EditTask(string index, string newTitle)
    {
        if(string.IsNullOrWhiteSpace(index) == false)
        {
            if(TryIndex(index, out int taskIndex))
            {
                if(string.IsNullOrWhiteSpace(newTitle) == false)
                {
                    tasks[taskIndex -1 ].Title = newTitle;
                    StorageService.SaveTasks(tasks, "tasks.json");
                }
                else
                {
                    Console.WriteLine("new task title cannot be empty.");
                }
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
            
        }
    }

    private bool TryIndex(string input, out int index)
    {
        if(int.TryParse(input, out index))
        {
            if(index > 0 && index <= tasks.Count)
            {
                return true;
            }
        }
        return false;
    }
}