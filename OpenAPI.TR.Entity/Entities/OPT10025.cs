using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>매물대집중요청</summary>
public class OPT10025 : TR
{
    /// <summary>매물대집중</summary>
    [DataMember, JsonProperty("매물대집중")]
    public MultiOPT10025[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.매물집중비율
    /// 3.현재가진입
    /// 4.매물대수
    /// 5.주기구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "매물집중비율", "현재가진입", "매물대수", "주기구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "매물대집중요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10025);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => Array.Empty<string>();
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "현재거래량", "가격대시작", "가격대끝", "매물량", "매물비" };
}