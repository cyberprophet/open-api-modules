using ShareInvest;
using ShareInvest.OpenAPI.Entity;

namespace OpenAPI.WinForm.x86;

partial class Kiwoom : Form
{
    internal Kiwoom()
    {
        InitializeComponent();

        var ax = new AxKH();
        var textBox = new TextBox
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            Multiline = true
        };
        Controls.Add(ax);
        Controls.Add(textBox);

        ax.Send += (sender, e) =>
        {
            textBox.Text = $"{e.ErrorCode} {e.RQName}";
        };
        ax.Dock = DockStyle.Fill;
        ax.Visible = false;

        textBox.Dock = DockStyle.Fill;

        TR tr = new Opt10001
        {
            Value = new[] { "005930" }
        };
        ax.API.OnReceiveTrData += (sender, e) =>
        {
            textBox.Text = ax.ConvertTrSingleData<string>(tr.Single, e);
        };
        ax.API.OnEventConnect += (sender, e) =>
        {
            if (e.nErrCode != 0)
            {
                textBox.Text = e.nErrCode.ToString();
            }
            Delay.Instance.Run();

            ax.CommRqData(tr);
        };
        ax.API.CommConnect();
    }
}