using AxKHOpenAPILib;

using Newtonsoft.Json;

namespace ShareInvest.Transmission;

class Opt20003 : Constructor
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
            dic = new Dictionary<string, string> { { Id[0], Value[0] } };

            for (int i = 0; i < Single.Length; i++)
            {
                dic[Single[i]] = axAPI.GetCommData(e.sTrCode, e.sRQName, 0, Single[i]).Trim();
            }

            if (dic.Count > 1)
            {
                yield return JsonConvert.SerializeObject(dic);
            }
        }

        if (Multiple != null)
        {
            var now = DateTime.Now;

            for (int i = 0; i < axAPI.GetRepeatCnt(e.sTrCode, e.sRQName); i++)
            {
                dic = new Dictionary<string, string>
                {
                    {
                        nameof(Entities.Kiwoom.OPT20003.Date),
                        (now.DayOfWeek switch
                        {
                            DayOfWeek.Sunday => now.AddDays(-2),
                            DayOfWeek.Saturday => now.AddDays(-1),
                            _ => now
                        }).ToString("yyyyMMdd")
                    }
                };

                for (int j = 0; j < Multiple.Length; j++)
                {
                    dic[Multiple[j]] = axAPI.GetCommData(e.sTrCode, e.sRQName, i, Multiple[j]).Trim();
                }
                yield return JsonConvert.SerializeObject(dic);
            }
        }
    }
}