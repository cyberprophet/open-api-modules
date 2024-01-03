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

        var now = DateTime.Now;

        response[Id[0]] = Value[0];
        response[nameof(Entities.Kiwoom.Opt50001.Date)] = (now.DayOfWeek switch
        {
            DayOfWeek.Sunday => now.AddDays(-2),
            DayOfWeek.Saturday => now.AddDays(-1),
            _ => now
        }).ToString("yyyyMMdd");

        yield return JsonConvert.SerializeObject(response);
    }
}