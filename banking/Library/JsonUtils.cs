using System.Text.Json;

namespace Library;
public static class JsonUtils
{
    public static async void ConvertToJsonAndWrite(object obj, string fileName)
    {
        var serializedObj = JsonSerializer.Serialize(obj);

        await File.WriteAllTextAsync(String.Format($"./data/{fileName}.json"), serializedObj);
    }
    public static async void ConvertToJsonAndWrite(string path, object obj, string fileName)
    {
        var serializedObj = JsonSerializer.Serialize(obj);

        if (path[-1] == '/')
        {
            await File.WriteAllTextAsync(String.Format($"{path}{fileName}.json"), serializedObj);
            return;
        }

        await File.WriteAllTextAsync(String.Format($"{path}/{fileName}.json"), serializedObj);
    }

    public static T ReadFromJson<T>(string path)
    {
        var jsonObj = File.ReadAllText(path);

        var obj = JsonSerializer.Deserialize<T>(jsonObj);

        if (obj is null)
        {
            throw new FileNotFoundException("This file could not be found!");
        }

        return obj;
    }
}
