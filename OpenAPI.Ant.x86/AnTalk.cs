using ShareInvest.Properties;

using System.Diagnostics;

namespace ShareInvest;

partial class AnTalk : Form
{
    DialogResult IsCancelled
    {
        get => MessageBox.Show(Resources.WARNING.Replace('|', '\n'), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
    }
    internal AnTalk(string serialKey, Icon[] icons)
    {
        this.icons = icons;
        this.serialKey = serialKey;

        InitializeComponent();
        InitializeComponent(axAPI = new AxKH());
    }
    bool IsExecuteTheScheduledTask(DateTime now)
    {
        return string.IsNullOrEmpty(webView.AccessToken) is false && (now.Hour < 4 || now.Hour > 6) && now.Second == Random.Shared.Next(now.Second);
    }
    void InitializeComponent(Control component)
    {
        _ = webView.EnsureCoreWebView2Async();

        Controls.Add(component);
        Controls.Add(webView);

        component.Dock = DockStyle.Fill;
        component.Visible = false;

        axAPI.Send += OnReceiveMessage;

        webView.Dock = DockStyle.Fill;

        timer.Start();
    }
    void TimerTick(object _, EventArgs e)
    {
        if (FormBorderStyle.Sizable == FormBorderStyle && FormWindowState.Minimized != WindowState)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;

            _ = Task.Run(() => { });
            return;
        }
        var now = DateTime.Now;

        if (Talk != null)
        {
            // TODO make socket if (HubConnectionState.Connected != Socket?.Hub.State)
            {
                _ = BeginInvoke(Dispose);
            }
            notifyIcon.Icon = icons[now.Second % 2];

            return;
        }
        if (axAPI.ConnectState)
        {
            return;
        }
        _ = BeginInvoke(() =>
        {
            if (IsExecuteTheScheduledTask(now) && axAPI.CommConnect())
            {
                Talk = new AnTalkClient(webView.Url, webView.AccessToken);

                Delay.Instance.Run();
            }
        });
        notifyIcon.Icon = icons[^1];
    }
    void StripItemClicked(object _, ToolStripItemClickedEventArgs e)
    {
        if (reference.Name.Equals(e.ClickedItem?.Name))
        {
            _ = BeginInvoke(() =>
            {
                if (Talk != null)
                {
                    Process.Start(new ProcessStartInfo("http://share.enterprises")
                    {
                        UseShellExecute = true
                    });
                    return;
                }
                if (string.IsNullOrEmpty(webView.AccessToken) is false && axAPI.CommConnect())
                {
                    Talk = new AnTalkClient(webView.Url, webView.AccessToken);

                    Delay.Instance.Run();
                }
            });
            return;
        }
        Close();
    }
    void SecuritiesResize(object _, EventArgs e)
    {
        SuspendLayout();

        Visible = false;
        ShowIcon = false;
        notifyIcon.Visible = true;

        ResumeLayout();
    }
    void JustBeforeFormClosing(object _, FormClosingEventArgs e)
    {
        if (Visible)
        {
            Hide();
        }
        if (CloseReason.UserClosing == e.CloseReason && DialogResult.Cancel == IsCancelled)
        {
            e.Cancel = true;

            return;
        }
        Dispose();
    }
    AnTalkClient? Talk
    {
        get; set;
    }
    readonly string serialKey;
    readonly Icon[] icons;
    readonly AxKH axAPI;
}