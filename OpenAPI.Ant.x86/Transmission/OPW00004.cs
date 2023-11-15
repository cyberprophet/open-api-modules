using AxKHOpenAPILib;

using Newtonsoft.Json;

using ShareInvest.Entities.Assets;

namespace ShareInvest.Transmission;

class OPW00004 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var response = OnReceiveTrSingleData(axAPI, e);

        response[Id[0]] = Value[0];
        response[nameof(AccOPW00004.Date)] = DateTime.Now.ToString("d", TrConstructor.Culture);

        yield return JsonConvert.SerializeObject(response);

        foreach (var storage in OnReceiveTrMultiData(axAPI, e))
        {
            if (storage.Count == 0)
            {
                continue;
            }
            storage[Id[0]] = Value[0];
            storage[nameof(BalOPW00004.Date)] = DateTime.Now.ToString("d", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
    }
}