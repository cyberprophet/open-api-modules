using ShareInvest.Services;

using System;
using System.ComponentModel;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ShareInvest;

public partial class Starter : Window
{
    public Starter()
    {
        register.IsWritable = IsRegistered;

        menu = new System.Windows.Forms.ContextMenuStrip
        {
            Cursor = System.Windows.Forms.Cursors.Hand
        };
        menu.Items.AddRange(new[]
        {
            new System.Windows.Forms.ToolStripMenuItem
            {
                Name = nameof(Properties.Resources.REGISTER),
                Text = IsRegistered ? Properties.Resources.UNREGISTER : Properties.Resources.REGISTER
            },
            new System.Windows.Forms.ToolStripMenuItem
            {
                Name = nameof(Properties.Resources.EXIT),
                Text = Properties.Resources.EXIT
            }
        });
        icons =
        [
            Properties.Resources.T1,
            Properties.Resources.T2,
            Properties.Resources.T3,
            Properties.Resources.T4,
            Properties.Resources.T5,
            Properties.Resources.T6
        ];
        notifyIcon = new System.Windows.Forms.NotifyIcon
        {
            ContextMenuStrip = menu,
            Visible = true,
            Text = Properties.Resources.ANT,
            Icon = Properties.Resources.T0,
            BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        };
        timer = new DispatcherTimer
        {
            Interval = new TimeSpan(0, 0, 1)
        };
        menu.ItemClicked += (_, e) =>
        {
            if (nameof(Properties.Resources.REGISTER).Equals(e.ClickedItem?.Name))
            {
                e.ClickedItem.Text = Properties.Resources.UNREGISTER.Equals(e.ClickedItem.Text) ? Properties.Resources.REGISTER : Properties.Resources.UNREGISTER;

                var fileName = string.Concat(Assembly.GetEntryAssembly()?.ManifestModule.Name[..^4], ".exe");

                register.IsWritable = register.IsWritable is false;

                var res = register.AddStartupProgram(Properties.Resources.ANT, fileName);

                if (string.IsNullOrEmpty(res) is false && notifyIcon != null)
                {
                    notifyIcon.Text = res;
                }
                return;
            }
            IsUserClosing = true;

            Close();
        };
        notifyIcon.MouseDoubleClick += (sender, _) =>
        {
            if (IsVisible == false)
            {
                Show();
            }
            else
            {
                Hide();
            }
        };
        timer.Tick += async (sender, e) =>
        {
            if (webView != null)
            {
                if (Update != null)
                {
                    notifyIcon.Icon = icons[DateTime.Now.Second % icons.Length];

                    if (Update.BeOutOperation)
                    {
                        timer.Interval = new TimeSpan(1, 1, 1, 0xC);

                        await Task.Delay(Random.Shared.Next(5 * 0x400, 0xA * 0x400));

                        webView.Reload();

                        await Task.Delay(0x400);

                        timer.Interval = await Update.RunAsync();
                    }
                    return;
                }
                if (string.IsNullOrEmpty(webView.AccessToken) is false)
                {
                    using (var sp = new SoundPlayer(Properties.Resources.BINGO))
                    {
                        Update = new Update(webView.Url, webView.AccessToken);

                        sp.PlaySync();
                    }
                }
                Visibility = (Visibility)await webView.InitializeCoreWebView2Async();
            }
            notifyIcon.Icon = Properties.Resources.T0;
        };
        InitializeComponent();

        webView = new CoreWebView(webView2);

        timer.Start();
    }
    void OnStateChanged(object sender, EventArgs e)
    {
        if (WindowState.Normal != WindowState)
        {
            Hide();
        }
    }
    void OnClosing(object sender, CancelEventArgs e)
    {
        if (IsUserClosing && MessageBoxResult.Cancel == MsgRes)
        {
            e.Cancel = true;

            return;
        }
        GC.Collect();
    }
    MessageBoxResult MsgRes
    {
        get => MessageBox.Show(Properties.Resources.WARNING.Replace('|', '\n'), Title, MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel);
    }
    Update? Update
    {
        get; set;
    }
    bool IsUserClosing
    {
        get; set;
    }
    bool IsRegistered
    {
        get => register.GetValue(Properties.Resources.ANT);
    }
    readonly System.Windows.Forms.ContextMenuStrip menu;
    readonly System.Windows.Forms.NotifyIcon notifyIcon;
    readonly System.Drawing.Icon[] icons;
    readonly DispatcherTimer timer;
    readonly CoreWebView webView;
    readonly Register register = new(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
}