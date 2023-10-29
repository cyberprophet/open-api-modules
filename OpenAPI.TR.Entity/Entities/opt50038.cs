using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별만기손익차트요청</summary>
public class Opt50038 : TR
{
    /// <summary>투자자별만기손익차트</summary>
    [DataMember, JsonProperty("투자자별만기손익차트")]
    public MultiOpt50038[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자구분
    /// 2.일자
    /// 3.투자자구분
    /// 4.수량금액구분
    /// </summary>
    public override string[] Id => new[] { "일자구분", "일자", "투자자구분", "수량금액구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "투자자별만기손익차트요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50038);
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
    public override string[] Multiple => new[] { "평가손익", "매입단가", "투자자별순매수수량", "미결제약정", "대비기호", "전일대비", "현재가", "종목코드", "행사가", "지수환산", "ATM구분", "대칭구분", "풋_종목코드", "풋_현재가", "풋_전일대비", "풋_대비기호", "풋_미결제약정", "풋_투자자별순매수수량", "풋_매입단가", "풋_평가손익" };
}