using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

/// <summary>선물분차트요청</summary>
class Opt50029 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        if (Multiple != null)
        {
            var data = axAPI.GetCommDataEx(e.sTrCode, e.sRQName);

            if (data != null)
            {
                int x, y, lx = ((object[,])data).GetUpperBound(0), ly = ((object[,])data).GetUpperBound(1);

                for (x = 0; x <= lx; x++)
                {
                    Dictionary<string, string> response = new()
                    {
                        {
                            Id![0],
                            Value![0]
                        }
                    };

                    for (y = 0; y <= ly; y++)
                    {
                        response[Multiple[y]] = ((string)((object[,])data)[x, y]).Trim();
                    }

                    yield return JsonConvert.SerializeObject(response);
                }

                yield return e.sPrevNext;
            }
        }
    }
}