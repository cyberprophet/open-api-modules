namespace OpenAPI.WinForm.x86;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Kiwoom());
    }
}