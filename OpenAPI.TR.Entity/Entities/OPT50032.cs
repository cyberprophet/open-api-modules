using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵당일실현손익요청</summary>
public class OPT50032 : TR
{
    /// <summary>선옵당일실현손익</summary>
    [DataMember, JsonProperty("선옵당일실현손익")]
    public MultiOPT50032[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.종목코드
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵당일실현손익요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50032);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "체결구분", "체결량", "매입단가", "체결가", "당일매도손익", "손익율", "당일매매수수료" };
}