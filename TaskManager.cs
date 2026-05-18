using System.Runtime.CompilerServices;

class TaskManager
{
    private List<TodoTask> tasks = new List<TodoTask>();

    public void AddTask(string title)
    {
        tasks.Add(new TodoTask { Title = title, IsCompleted = false });
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
        foreach (var task in tasks)
        {
            if (task.Title == title)
            {
                task.IsCompleted = true;
                break;
            }
        }
    }

    public void DeleteTask(string title)
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
}