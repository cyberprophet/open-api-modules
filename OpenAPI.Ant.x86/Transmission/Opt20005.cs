using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

/// <summary>업종분봉조회요청</summary>
class Opt20005 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        Dictionary<string, string> response = OnReceiveTrSingleData(axAPI, e);

        if (Multiple != null && Single != null)
        {
            var data = axAPI.GetCommDataEx(e.sTrCode, e.sRQName);

            if (data != null)
            {
                int x, y, lx = ((object[,])data).GetUpperBound(0), ly = ((object[,])data).GetUpperBound(1);

                string code = response.ElementAt(0).Value, name = axAPI.GetMasterCodeName(code);

                for (x = 0; x <= lx; x++)
                {
                    response = new Dictionary<string, string>
                    {
                        { nameof(OpenAPI.Entity.SingleOpt20005.Name), name },
                        { Single[0], code }
                    };

                    for (y = 0; y <= ly; y++)
                    {
                        response[Multiple[y]] = ((string)((object[,])data)[x, y]).Trim();
                    }
                    response[nameof(Entities.Kiwoom.Opt20005.Date)] = response[time][..8];

                    yield return JsonConvert.SerializeObject(response);
                }
                yield return e.sPrevNext;
            }
        }
    }

    const string time = "체결시간";
}