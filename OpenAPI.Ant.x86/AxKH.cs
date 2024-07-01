using AxKHOpenAPILib;

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
    public event EventHandler<MsgEventArgs>? Send;

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

    internal void SendOrder(OpenAPI.Order o)
    {
        Delay.Instance.RequestTheMission(new Task(() =>
        {
            var order = axAPI.SendOrder(o.RQName, o.ScreenNo, o.AccNo, o.OrderType, o.Code, o.Qty, o.Price, o.HogaGb, o.OrgOrderNo);

            OnReceiveErrMessage(o.RQName, order);
        }));
        Delay.Instance.Milliseconds = 0xC7;
    }

    internal void SendOrderFO(OpenAPI.OrderFO o)
    {
        Delay.Instance.RequestTheMission(new Task(() =>
        {
            var order = axAPI.SendOrderFO(o.RQName, o.ScreenNo, o.AccNo, o.Code, o.OrdKind, o.SlbyTp, o.OrdTp, o.Qty, o.Price, o.OrgOrdNo);

            OnReceiveErrMessage(o.RQName, order);
        }));
        Delay.Instance.Milliseconds = 0xC7;
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

            Send?.Invoke(this, new SecuritiesEventArgs(new Securities
            {
                MacAddress = Service.GetMacAddress()
            }));
            return;
        }
        Send?.Invoke(this, new ErrMsgEventArgs(sender.GetType().Name));
    }

    void OnReceiveTrData(object _, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if ("KOA".Equals(e.sTrCode[..3]))
        {
            var orderNumber = axAPI.GetCommData(e.sTrCode, e.sRQName, 0, "주문번호");

            Send?.Invoke(this, new AxMsgEventArgs(new OpenMessage
            {
                Code = e.sRQName,
                Title = e.sTrCode,
                Screen = string.IsNullOrEmpty(orderNumber) ? e.sScrNo : orderNumber
            }));
            return;
        }
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
        Debug.WriteLine(nameof(OnReceiveTrData));
    }

    void OnReceiveChejanData(object _, _DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
    {
        if (e.sGubun.Length != 1 && Enum.IsDefined(typeof(ChejanType), (int)e.sGubun[0]) is false)
        {
            return;
        }
        var chejanType = Enum.ToObject(typeof(ChejanType), (int)e.sGubun[0]);
        var receiver = new Dictionary<string, string>
        {
            { nameof(Chejan.Date), DateTime.Now.ToString("d", TrConstructor.Culture) }
        };
        switch (chejanType)
        {
            case ChejanType.주문체결:

                foreach (var cs in Enum.GetValues<Conclusion>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                break;

            case ChejanType.잔고:

                foreach (var cs in Enum.GetValues<Balance>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                break;

            case ChejanType.파생잔고:

                foreach (var cs in Enum.GetValues<Derivatives>())
                {
                    receiver[cs.ToString()] = axAPI.GetChejanData((int)cs).Trim();
                }
                break;
        }
        Send?.Invoke(this, new ChejanEventArgs((ChejanType)chejanType, receiver));
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
        RequestForFuturesInfomation(axAPI.GetFutureList().Split(';'));
    }

    /// <summary>
    /// 1(A)01.KOSPI200
    /// 1(A)06.KOSDAQ150
    /// </summary>
    void RequestForFuturesInfomation(string[] futures)
    {
        var futuresInventory = new List<string>(
        [
            futures[0],
            futures[Array.FindIndex(futures, match => "106".Equals(match[..3]) || "A06".Equals(match[..3]))]
        ]);
        foreach (var code in futuresInventory)
        {
            CommRqData(new OpenAPI.Entity.Opt50001
            {
                Value = [code],
                PrevNext = 0
            });
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
}