using AxKHOpenAPILib;

using Newtonsoft.Json;

using System.Diagnostics;

namespace ShareInvest.Transmission;

class Opt20001 : Constructor
{
    internal override IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
    {
        Dictionary<string, string> dic;

        if (Id == null || Value == null)
        {
            yield break;
        }

        if (Single != null)
        {
            var now = DateTime.Now;

            dic = new Dictionary<string, string>
            {
                {
                    nameof(Entities.Kiwoom.OPT20001.Date),
                    (now.DayOfWeek switch
                    {
                        DayOfWeek.Sunday => now.AddDays(-2),
                        DayOfWeek.Saturday => now.AddDays(-1),
                        _ => now
                    }).ToString("yyyyMMdd")
                },
                { Id[0], Value[0] },
                { Id[1], Value[1] }
            };

            for (int i = 0; i < Single.Length; i++)
            {
                dic[Single[i]] = axAPI.GetCommData(e.sTrCode, e.sRQName, 0, Single[i]).Trim();
            }

            if (dic.Count > 2)
            {
                yield return JsonConvert.SerializeObject(dic);
            }
        }

        if (Multiple != null)
        {
            for (int i = 0; i < axAPI.GetRepeatCnt(e.sTrCode, e.sRQName); i++)
            {
                dic = new Dictionary<string, string>
                {
                    { Id[0], Value[0] },
                    { Id[1], Value[1] }
                };

                for (int j = 0; j < Multiple.Length; j++)
                {
                    dic[Multiple[j]] = axAPI.GetCommData(e.sTrCode, e.sRQName, i, Multiple[j]).Trim();
                }
#if DEBUG
                Debug.WriteLine(JsonConvert.SerializeObject(dic, Formatting.Indented));
#endif
            }
        }
    }
}