using System.Runtime.CompilerServices;

class TaskManager
{
    private List<TodoTask> tasks = new List<TodoTask>();

    public void AddTask(string title)
    {
        if(title != "")
        {tasks.Add(new TodoTask { Title = title, IsCompleted = false });
        }
        else
        {
            Console.WriteLine("Task title cannot be empty.");
        }
    }

    public void ShowTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Title} - {(task.IsCompleted ? "Completed" :"Not Completed")}");
        }
    }

    public void CompleteTask(string title)
    {
        if(title != "")
        {
            foreach (var task in tasks)
            {
                if (task.Title == title)
                {   
                task.IsCompleted = true;
                break;
                }
            }
        }
        else
        {
            Console.WriteLine("Task title cannot be empty.");
        }
    }

    public void DeleteTask(string title)
    {
        if(title != "")
        {
            foreach (var task in tasks)
            {
                if (task.Title == title)
                {
                    tasks.Remove(task);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Task title cannot be empty.");
        }
    }
}