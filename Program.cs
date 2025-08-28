namespace ComparadorSchema;

internal static class Program
{    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Frm_Main());
    }
}