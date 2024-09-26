using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

/// <summary>선옵잔고현황정산가기준요청</summary>
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

        if (string.IsNullOrEmpty(res?.NumberOfOutputs) || int.TryParse(res.NumberOfOutputs, out int numberOfOutputs) && numberOfOutputs == 0)
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
            storage[nameof(Entities.Assets.Opw20007.Date)] = DateTime.Now.ToString("d", TrConstructor.Culture);

            yield return JsonConvert.SerializeObject(storage);
        }
    }
}