using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class OPTKWFID : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Multiple == null)
        {
            yield break;
        }
        foreach (var response in OnReceiveTrMultiData(axAPI, e))
        {
            if (response.Count == 0)
            {
                continue;
            }
            string code = response[Multiple[0]];

            response[nameof(Entities.Kiwoom.OPTKWFID.State)] = axAPI.GetMasterStockState(code);
            response[Multiple[0x24]] = axAPI.KOA_Functions("GetMasterListedStockCntEx", code);
            response[nameof(Entities.Kiwoom.OPTKWFID.InvestmentCaution)] = axAPI.KOA_Functions("IsOrderWarningStock", code);
            response[nameof(Entities.Kiwoom.OPTKWFID.ListingDate)] = axAPI.GetMasterListedStockDate(code);
            response[nameof(Entities.Kiwoom.OPTKWFID.ConstructionSupervision)] = axAPI.KOA_Functions("GetMasterStockInfo", code).Replace(';', '+');

            yield return JsonConvert.SerializeObject(response);
        }
    }
}