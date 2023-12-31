using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class Opw20007 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Id == null || Value == null)
        {
            yield break;
        }
        var response = OnReceiveTrSingleData(axAPI, e);

        var res = JsonConvert.DeserializeObject<OpenAPI.Entity.SingleOpw20007>(JsonConvert.SerializeObject(response));

        _ = int.TryParse(res?.NumberOfOutputs, out int numberOfOutputs);

        foreach (var storage in OnReceiveTrMultiData(axAPI, e))
        {
            if (storage.Count == 0)
            {
                continue;
            }
            storage[Id[0]] = Value[0];
            storage[nameof(Entities.Assets.Opw20007.NumberOfOutputs)] = numberOfOutputs--.ToString("D4");
            storage[nameof(Entities.Assets.Opw20007.Date)] = DateTime.Now.ToString("d", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
    }
}