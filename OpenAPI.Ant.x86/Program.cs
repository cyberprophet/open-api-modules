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
            Application.Run(new AnTalk(new AxKH(), serialKey,
            [
                Resources.DARK,
                Resources.LOGO,
                Resources.DISABLE
            ]));
            GC.Collect();
        }
        Process.GetCurrentProcess().Kill();
    }
}