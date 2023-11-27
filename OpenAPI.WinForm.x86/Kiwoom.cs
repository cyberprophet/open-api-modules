using ShareInvest;
using ShareInvest.OpenAPI.Entity;

namespace OpenAPI.WinForm.x86;

partial class Kiwoom : Form
{
    internal Kiwoom()
    {
        InitializeComponent();

        ax = new AxKH();
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

        ax.API.OnReceiveTrData += (sender, e) =>
        {
            foreach (var str in ax.ConvertTrMultiData<string>(new Opt10004().Multiple, e))
            {
                textBox.Text = str;
            }
        };
        ax.API.OnEventConnect += (sender, e) =>
        {
            if (e.nErrCode != 0)
            {
                textBox.Text = e.nErrCode.ToString();
            }
            foreach (var code in GetCodeListByMarket())
            {
                ax.CommRqData(new Opt10004
                {
                    Value = new[] { code }
                });
            }
            Delay.Instance.Run();
        };
        Delay.Instance.Milliseconds = 101;
        ax.API.CommConnect();
    }
    IEnumerable<string> GetCodeListByMarket()
    {
        List<string> codeListByMarket = new(ax.API.GetCodeListByMarket("0").Split(';').OrderBy(o => Guid.NewGuid()));

        codeListByMarket.AddRange(ax.API.GetCodeListByMarket("10").Split(';').OrderBy(o => Guid.NewGuid()));

        foreach (var code in codeListByMarket)
        {
            yield return code;
        }
    }
    readonly AxKH ax;
}