using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래량갱신요청</summary>
public class OPT10024 : TR
{
    /// <summary>거래량갱신</summary>
    [DataMember, JsonProperty("거래량갱신")]
    public MultiOPT10024[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.주기구분
    /// 3.거래량구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "주기구분", "거래량구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래량갱신요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10024);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "이전거래량", "현재거래량", "매도호가", "매수호가" };
}