using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식외국인요청</summary>
public class Opt10008 : TR
{
    /// <summary>주식외국인</summary>
    [DataMember, JsonProperty("주식외국인")]
    public MultiOpt10008[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식외국인요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10008);
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
    public override string[] Multiple => new[] { "일자", "종가", "전일대비", "거래량", "변동수량", "보유주식수", "비중", "취득가능주식수", "외국인한도", "외국인한도증감", "한도소진률" };
}