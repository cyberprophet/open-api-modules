using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>체결정보요청</summary>
public class Opt10003 : TR
{
    /// <summary>체결정보</summary>
    [DataMember, JsonProperty("체결정보")]
    public MultiOpt10003[]? MultiResponse
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
        get => "체결정보요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10003);
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
    public override string[] Multiple => new[] { "시간", "현재가", "전일대비", "대비율", "우선매도호가단위", "우선매수호가단위", "체결거래량", "sign", "누적거래량", "누적거래대금", "체결강도" };
}