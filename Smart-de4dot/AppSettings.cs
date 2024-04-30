namespace Smart_de4dot;

public class AppSettings : JsonHelper<AppSettings>
{
    public List<ItemInfo> ListDe4Dot { get; set; } = [];
}