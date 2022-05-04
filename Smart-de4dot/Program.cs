global using Newtonsoft.Json;
global using System.Diagnostics;

namespace Smart_de4dot;

internal static class Program
{
    public static AppSettings Settings = new AppSettings();

    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        Settings = AppSettings.Load();
        Application.Run(new FrmMain(args));
    }
}