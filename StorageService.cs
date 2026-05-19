using System.Text.Json;

class StorageService
{
    public static void SaveTasks(List<TodoTask> tasks, string filePath)
    {
        var json = JsonSerializer.Serialize(tasks);
        File.WriteAllText(filePath, json);
    }

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