using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵호가잔량추이요청</summary>
public class Opt50011 : TR
{
    /// <summary>선옵호가잔량추이</summary>
    [DataMember, JsonProperty("선옵호가잔량추이")]
    public MultiOpt50011[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간단위
    /// 3.시간검색
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간단위", "시간검색" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵호가잔량추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50011);
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
    public override string[] Multiple => new[] { "호가시간", "매도호가수량", "최우선매도호가", "매수호가수량", "최우선매수호가", "호가순잔량", "매도호가총잔량", "매수호가총잔량", "순매수잔량" };
}