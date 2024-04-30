namespace Smart_de4dot;

public class JsonHelper<T> where T : new()
{
    private static readonly string DefaultFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

    public void Save(string? fileName = null)
    {
        fileName = UpdateFileName(fileName);
        File.WriteAllText(fileName, JsonConvert.SerializeObject(this, Formatting.Indented));
    }

    public static T Load(string? fileName = null)
    {
        fileName = UpdateFileName(fileName);
        var jsonContent = new T();
        if (File.Exists(fileName))
            jsonContent = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));

        return jsonContent ?? new T();
    }

    private static string UpdateFileName(string? fileName)
    {
        return string.IsNullOrWhiteSpace(fileName) ? DefaultFilename : fileName;
    }
}