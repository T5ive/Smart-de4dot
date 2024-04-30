namespace Smart_de4dot;

internal static class Program
{
    public static AppSettings Settings = new();

    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmMain(args));
    }
}