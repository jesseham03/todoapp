using System.Text.Json;

// in this class we will handle the saving and loading of tasks to and from a json file.
class StorageService
{
    //method to save the tasks to a json file
    public static void SaveTasks(List<TodoTask> tasks, string filePath)
    {
        var json = JsonSerializer.Serialize(tasks);
        File.WriteAllText(filePath, json);
    }

    //method to load the tasks from a json file
    public static List<TodoTask> LoadTasks(string filePath)
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TodoTask>>(json) ?? new List<TodoTask>();
        }
        else
        {
            return new List<TodoTask>();
        }
    }
}