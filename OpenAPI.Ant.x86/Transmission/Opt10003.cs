using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

/// <summary>체결정보요청</summary>
class Opt10003 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var now = DateTime.Now;

        foreach (var storage in OnReceiveTrMultiData(axAPI, e))
        {
            if (storage.Count == 0)
            {
                continue;
            }
            storage[Id[0]] = Value[0];
            storage[nameof(Entities.Kiwoom.Opt10003.Date)] = (now.DayOfWeek switch
            {
                DayOfWeek.Sunday => now.AddDays(-2),
                DayOfWeek.Saturday => now.AddDays(-1),
                _ => now.Hour < 5 ? now.AddDays(-1) : now
            }).ToString("yyyyMMdd", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
        yield return e.sPrevNext;
    }
}