using System.Runtime.CompilerServices;

class TaskManager
{
    private List<TodoTask> tasks;

    public void AddTask(string title)
    {
        tasks.Add(new TodoTask { Title = title, IsCompleted = false });
    }
}