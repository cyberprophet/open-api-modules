using AxKHOpenAPILib;

using Newtonsoft.Json;

using ShareInvest.Entities;
using ShareInvest.Entities.Kiwoom;
using ShareInvest.Observers;
using ShareInvest.OpenAPI.Entity;
using ShareInvest.Services;
using ShareInvest.Transmission;

using System.Diagnostics;
using System.Reflection;

namespace ShareInvest;

partial class AxKH : UserControl, IEventHandler<MsgEventArgs>
{
    internal AxKH()
    {
        Delay.Instance.Milliseconds = 0x259;

        InitializeComponent();
    }
    internal void CommRqData(TR? tr)
    {
        if (tr?.Value == null)
        {
            return;
        }
        string sScrNo = tr.ScreenNo;

        Delay.Instance.RequestTheMission(new Task(() =>
        {
            for (int index = 0; index < tr.Id.Length; index++)
            {
                axAPI.SetInputValue(tr.Id[index], tr.Value[index]);
            }
            OnReceiveErrMessage(tr.RQName, axAPI.CommRqData(tr.RQName, tr.TrCode, tr.PrevNext, sScrNo));
        }));
        Cache.SaveTemporarily(sScrNo, tr);
    }
    internal bool CommConnect()
    {
        axAPI.OnReceiveMsg += OnReceiveMsg;
        axAPI.OnReceiveRealData += OnReceiveRealData;
        axAPI.OnReceiveChejanData += OnReceiveChejanData;
        axAPI.OnReceiveTrData += OnReceiveTrData;
        axAPI.OnEventConnect += OnEventConnect;

        return axAPI.CommConnect() == 0;
    }
    internal bool ConnectState
    {
        get => axAPI.GetConnectState() == 1;
    }
    void OnEventConnect(object sender, _DKHOpenAPIEvents_OnEventConnectEvent e)
    {
        if (e.nErrCode != 0)
        {
            OnReceiveErrMessage(sender.GetType().Name, e.nErrCode);

            return;
        }
        if (ServerType)
        {
            GetUserInfo();
            GetCodeListByMarket();

            return;
        }
        Send?.Invoke(this, new ErrMsgEventArgs(sender.GetType().Name));
    }
    void OnReceiveTrData(object _, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        var typeName = string.Concat(typeof(Constructor).Namespace, '.', e.sTrCode);

        if (Assembly.GetExecutingAssembly().CreateInstance(typeName, true) is Constructor ctor && Cache.GetConstructor(e.sTrCode, e.sScrNo) is TR tr)
        {
            ctor.Single = tr.Single;
            ctor.Multiple = tr.Multiple;
            ctor.Value = tr.Value;
            ctor.Id = tr.Id;

            foreach (var json in ctor.OnReceiveTrData(axAPI, e))
            {
                if (json.Length == 1)
                {
                    if (int.TryParse(json, out int next))
                    {
                        tr.PrevNext = next;

                        Send?.Invoke(this, new TransmissionEventArgs(tr));
                    }
                    continue;
                }
                Send?.Invoke(this, new JsonMsgEventArgs(tr, json));
            }
            Send?.Invoke(this, new AxMsgEventArgs(new OpenMessage
            {
                Title = e.sTrCode,
                Code = e.sRQName,
                Screen = e.sScrNo
            }));
            return;
        }
#if DEBUG
        Debug.WriteLine(nameof(OnReceiveTrData));
#endif
    }
    void OnReceiveChejanData(object _, _DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
    {
        if (e.sGubun.Length != 1 && Enum.IsDefined(typeof(ChejanType), (int)e.sGubun[0]) is false)
        {
            return;
        }
        Type receiverType = typeof(Chejan);

        var receiver = new Dictionary<string, string>
        {
            { nameof(Chejan.Date), DateTime.Now.ToString("d", TrConstructor.Culture) }
        };
        switch (Enum.ToObject(typeof(ChejanType), (int)e.sGubun[0]))
        {
            case ChejanType.주문체결:
                foreach (var cs in Enum.GetValues<Conclusion>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                receiverType = typeof(ChejanConclusion);
                break;

            case ChejanType.잔고:
                foreach (var cs in Enum.GetValues<Balance>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                receiverType = typeof(ChejanBalance);
                break;

            case ChejanType.파생잔고:
                foreach (var cs in Enum.GetValues<Derivatives>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                receiverType = typeof(ChejanDerivatives);
                break;
        }
        Send?.Invoke(this, new ChejanEventArgs(receiverType, JsonConvert.SerializeObject(receiver)));
    }
    void OnReceiveRealData(object _, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
    {
        Send?.Invoke(this, new RealMsgEventArgs(e.sRealType, e.sRealKey, e.sRealData));
    }
    void OnReceiveMsg(object _, _DKHOpenAPIEvents_OnReceiveMsgEvent e)
    {
        Send?.Invoke(this, new AxMsgEventArgs(new OpenMessage
        {
            Title = e.sMsg[9..],
            Code = e.sRQName,
            Screen = e.sScrNo
        }));
    }
    void OnReceiveErrMessage(string? sRQName, int errCode)
    {
        if (errCode >= 0)
        {
            return;
        }
        Send?.Invoke(this, new AxMsgEventArgs(new OpenMessage
        {
            Title = Cache.Error[errCode],
            Code = sRQName,
            Screen = Math.Abs(errCode).ToString("D4")
        }));
    }
    void GetUserInfo()
    {
        var id = axAPI.GetLoginInfo("USER_ID");
        var name = axAPI.GetLoginInfo("USER_NAME");

        foreach (var accNo in axAPI.GetLoginInfo("ACCLIST").Split(';').Where(selector => selector.Length == 0xA))
        {
            Send?.Invoke(this, new SecuritiesEventArgs(new Securities
            {
                AccNo = accNo,
                SecuritiesId = id,
                UserName = name
            }));
        }
    }
    /// <summary>
    /// 0.KOSPI
    /// 10.KOSDAQ
    /// </summary>
    void GetCodeListByMarket()
    {
        List<string> codeListByMarket = new(axAPI.GetCodeListByMarket("0").Split(';').OrderBy(o => Guid.NewGuid()));

        codeListByMarket.AddRange(axAPI.GetCodeListByMarket("10").Split(';').OrderBy(o => Guid.NewGuid()));

        foreach (var tr in TrConstructor.GetInventoryOnConditions(codeListByMarket))
        {
            if (tr.Value != null)
            {
                var nCodeCount = tr.PrevNext;

                tr.PrevNext = 0;

                Delay.Instance.RequestTheMission(new Task(() =>
                {
                    OnReceiveErrMessage(tr.RQName, axAPI.CommKwRqData(tr.Value[0], tr.PrevNext, nCodeCount, 0, tr.RQName, tr.ScreenNo));
                }));
            }
        }
    }
    bool ServerType
    {
        get
        {
            var serverType = axAPI.GetLoginInfo("GetServerGubun");

            return string.IsNullOrEmpty(serverType) || int.TryParse(serverType, out int mock) && mock != 1;
        }
    }
    public event EventHandler<MsgEventArgs>? Send;
}