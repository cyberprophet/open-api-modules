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
            Thread.Sleep(Random.Shared.Next(0x400 * 3, 0x400 * 7));
        }
        GC.Collect();

        Process.GetCurrentProcess().Kill();
    }
}