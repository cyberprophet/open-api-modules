using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신주인수권전체시세요청</summary>
public class Opt10011 : TR
{
    /// <summary>신주인수권시세</summary>
    [DataMember, JsonProperty("신주인수권시세")]
    public MultiOpt10011[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.신주인수권구분
    /// </summary>
    public override string[] Id => new[] { "신주인수권구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신주인수권전체시세요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10011);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락율", "최우선매도호가", "최우선매수호가", "누적거래량", "시가", "고가", "저가" };
}