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
        for (int i = 0; i < tasks.Count; i++)
        {
            var task = tasks[i];
            Console.WriteLine($"{i + 1}. {task.Title} - {(task.IsCompleted ? "completed" : "not completed")}");
        }
    }

    public void CompleteTask(string index)
    {
        if(index != "")
        {
            tasks[int.Parse(index) - 1].IsCompleted = true;
        }
        else
        {
            Console.WriteLine("Task index cannot be empty.");
        }
    }

    public void DeleteTask(string index)
    {
        if(index != "")
        {
            tasks.Remove(tasks[int.Parse(index) -1 ]);
        }
        else
        {
            Console.WriteLine("Task index cannot be empty.");
        }
    }
}