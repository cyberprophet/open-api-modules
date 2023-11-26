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
            textBox.Text = ax.ConvertTrSingleData<string>(new Opt10001().Single, e);
        };
        ax.API.OnEventConnect += async (sender, e) =>
        {
            if (e.nErrCode != 0)
            {
                textBox.Text = e.nErrCode.ToString();
            }
            foreach (var code in GetCodeListByMarket())
            {
                var delayTime = RequestLimit.CheckAndResetLimits();

                if (delayTime != 0)
                {
                    textBox.Text = $"Count: {CodeCount}\nSeconds: {RequestLimit.GetDelaySeconds()}\nMinutes: {RequestLimit.GetDelayMinute()}\nHours: {RequestLimit.GetDelayHour()}";
                }
                await Task.Delay((int)delayTime + 1);

                ax.CommRqData(new Opt10001
                {
                    Value = new[] { code }
                });
                CodeCount++;
            }
        };
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
    uint CodeCount
    {
        get; set;
    }
    readonly AxKH ax;
}