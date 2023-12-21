using ShareInvest;
using ShareInvest.OpenAPI.Entity;

using System.Diagnostics;
using System.Text;

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

        var scrNo = 1000;

        ax.API.OnReceiveTrData += (sender, e) =>
        {
            foreach (var str in ax.ConvertTrMultiData<string>(new Opt50001().Multiple, e))
            {
                textBox.Text = str;

                Debug.WriteLine(str);
            }
            Debug.WriteLine(ax.ConvertTrSingleData<string>(new Opt50001().Single, e));
        };
        ax.API.OnEventConnect += (sender, e) =>
        {
            if (e.nErrCode != 0)
            {
                textBox.Text = e.nErrCode.ToString();
            }
            foreach (var code in ax.API.GetFutureList().Split(';'))
            {
                Debug.WriteLine(code);
            }
            ax.CommRqData(new Opt50001
            {
                Value = new[]
                {
                    "106V3000"
                },
                PrevNext = 0
            });
            Delay.Instance.Run();
        };
        Delay.Instance.Milliseconds = 101;
        ax.API.CommConnect();
    }
    IEnumerable<string> GetCodeListByFutures()
    {
        var index = 0;
        var sb = new StringBuilder();
        var queue = new Queue<StringBuilder>();

        foreach (var code in ax.API.GetFutureList().Split(';').Where(e => e[0] == '1'))
        {
            if (index++ % 100 == 99)
            {
                queue.Enqueue(sb);

                sb = new StringBuilder();
            }
            sb.Append(code).Append(';');
        }
        queue.Enqueue(sb.Remove(sb.Length - 1, 1));

        while (queue.TryDequeue(out StringBuilder? str))
        {
            yield return str.ToString();
        }
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