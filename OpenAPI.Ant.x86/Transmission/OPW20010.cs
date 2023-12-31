using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class OPW20010 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var response = OnReceiveTrSingleData(axAPI, e);

        response[Id[0]] = Value[0];
        response[nameof(Entities.Assets.OPW20010.Date)] = DateTime.Now.ToString("d", TrConstructor.Culture);

        yield return JsonConvert.SerializeObject(response);
    }
}