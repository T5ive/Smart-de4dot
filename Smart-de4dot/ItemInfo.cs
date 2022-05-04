namespace Smart_de4dot;

public class AppSettings : JsonHelper<AppSettings>
{
    public List<ItemInfo> ListDe4Dot { get; set; } = new List<ItemInfo>();
}

public class JsonHelper<T> where T : new()
{
    private const string DefaultFilename = "settings.json";

    public void Save(string fileName = DefaultFilename)
    {
        File.WriteAllText(fileName, JsonConvert.SerializeObject(this, Formatting.Indented));
    }

    public static T Load(string fileName = DefaultFilename)
    {
        var t = new T();
        if (File.Exists(fileName))
            t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
        return t;
    }
}

public class ItemInfo
{
    public string Name { get; set; }

    public string Path { get; set; }
}