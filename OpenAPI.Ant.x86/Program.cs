using ShareInvest.Properties;

using System.Diagnostics;

namespace ShareInvest;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        if (Authentication.GetKey(KeyDecoder.ProductKeyFromRegistry?.Split('-')) is string serialKey)
        {
            Application.Run(new AnTalk(serialKey, new[]
            {
                Resources.DARK,
                Resources.LOGO,
                Resources.DISABLE
            }));
            GC.Collect();
        }
        Process.GetCurrentProcess().Kill();
    }
}