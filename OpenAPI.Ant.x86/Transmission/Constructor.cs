using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class Constructor
{
    protected internal Dictionary<string, string> OnReceiveTrSingleData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        Dictionary<string, string> response = [];

        for (int i = 0; i < Single?.Length; i++)
        {
            response[Single[i]] = axAPI.GetCommData(e.sTrCode, e.sRQName, 0, Single[i]).Trim();
        }
        return response;
    }

    protected internal IEnumerable<Dictionary<string, string>> OnReceiveTrMultiData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        Dictionary<string, string> response;

        for (int i = 0; i < axAPI.GetRepeatCnt(e.sTrCode, e.sRQName); i++)
        {
            response = [];

            for (int j = 0; j < Multiple?.Length; j++)
            {
                response[Multiple[j]] = axAPI.GetCommData(e.sTrCode, e.sRQName, i, Multiple[j]).Trim();
            }
            if (response.Count > 0)
            {
                yield return response;
            }
        }
    }

    internal string[]? Multiple
    {
        get; set;
    }

    internal string[]? Single
    {
        get; set;
    }

    internal string[]? Value
    {
        get; set;
    }

    internal string[]? Id
    {
        get; set;
    }

    internal virtual IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent trData)
    {
        if (Single?.Length > 0)
        {
            yield return JsonConvert.SerializeObject(OnReceiveTrSingleData(axAPI, trData));
        }
        if (Multiple?.Length > 0)
        {
            foreach (var e in OnReceiveTrMultiData(axAPI, trData))
            {
                yield return JsonConvert.SerializeObject(e);
            }
        }
    }
}