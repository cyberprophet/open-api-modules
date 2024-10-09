using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

/// <summary>선옵체결추이요청</summary>
class OPT50006 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var singleData = OnReceiveTrSingleData(axAPI, e);

        foreach (var storage in OnReceiveTrMultiData(axAPI, e))
        {
            if (storage.Count == 0)
            {
                continue;
            }

            foreach (var single in singleData)
            {
                storage[single.Key] = single.Value;
            }
            storage[Id[0]] = Value[0];
            storage[nameof(Entities.Kiwoom.OPT50006.Date)] = DateTime.Now.ToString("yyyyMMdd", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
        yield return e.sPrevNext;
    }
}