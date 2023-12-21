using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class Opt50001 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var response = OnReceiveTrSingleData(axAPI, e);

        response[Id[0]] = Value[0];
        response[nameof(Entities.Kiwoom.Opt50001.Date)] = DateTime.Now.ToString("yyyyMMdd");

        yield return JsonConvert.SerializeObject(response);
    }
}