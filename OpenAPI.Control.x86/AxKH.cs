using AxKHOpenAPILib;

using Newtonsoft.Json;

using ShareInvest.OpenAPI.Entity;

namespace ShareInvest;

public partial class AxKH : UserControl
{
    public IEnumerable<T> ConvertTrMultiData<T>(string[] multiInputValues, _DKHOpenAPIEvents_OnReceiveTrDataEvent e) where T : class
    {
        Queue<T> queue = new();

        for (int i = 0; i < axAPI.GetRepeatCnt(e.sTrCode, e.sRQName); i++)
        {
            Dictionary<string, string> dic = new();

            for (int j = 0; j < multiInputValues.Length; j++)
            {
                dic[multiInputValues[j]] = axAPI.GetCommData(e.sTrCode, e.sRQName, i, multiInputValues[j]).Trim();
            }
            if (ConvertTrSingleData(typeof(T), dic) is T data)
            {
                queue.Enqueue(data);
            }
        }
        return queue;
    }
    public T? ConvertTrSingleData<T>(string[] singleInputValues, _DKHOpenAPIEvents_OnReceiveTrDataEvent e) where T : class
    {
        Dictionary<string, string> dic = new();

        for (int i = 0; i < singleInputValues.Length; i++)
        {
            dic[singleInputValues[i]] = axAPI.GetCommData(e.sTrCode, e.sRQName, 0, singleInputValues[i]).Trim();
        }
        return ConvertTrSingleData(typeof(T), dic) as T;
    }
    public void GetCodeListByMarket()
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
    public void CommRqData(TR tr)
    {
        Delay.Instance.RequestTheMission(new Task(() =>
        {
            for (int index = 0; index < tr.Id.Length; index++)
            {
                axAPI.SetInputValue(tr.Id[index], tr.Value?[index]);
            }
            OnReceiveErrMessage(tr.RQName, axAPI.CommRqData(tr.RQName, tr.TrCode, tr.PrevNext, tr.ScreenNo));
        }));
    }
    public AxKHOpenAPI API
    {
        get => axAPI;
    }
    public AxKH()
    {
        Delay.Instance.Milliseconds = 0x259;

        InitializeComponent();
    }
    void OnReceiveErrMessage(string? sRQName, int errCode)
    {
        Send?.Invoke(this, new AxErrCodeEventArgs(sRQName, errCode));
    }
    static object ConvertTrSingleData(Type type, Dictionary<string, string> dic)
    {
        if (type == typeof(Dictionary<string, string>))
        {
            return dic;
        }
        return JsonConvert.SerializeObject(dic
#if DEBUG
            , Formatting.Indented
#endif
            );
    }
    public event EventHandler<AxErrCodeEventArgs>? Send;
}