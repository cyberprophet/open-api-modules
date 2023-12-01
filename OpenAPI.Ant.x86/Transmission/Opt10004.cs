using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class Opt10004 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        foreach (var storage in OnReceiveTrMultiData(axAPI, e))
        {
            if (storage.Count == 0)
            {
                continue;
            }
            storage[Id[0]] = Value[0];
            storage[nameof(Entities.Kiwoom.Opt10004.Date)] = DateTime.Now.ToString("yyyyMMdd", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
    }
}