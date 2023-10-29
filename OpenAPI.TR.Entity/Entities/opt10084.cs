using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일전일체결요청</summary>
public class Opt10084 : TR
{
    /// <summary>당일전일체결</summary>
    [DataMember, JsonProperty("당일전일체결")]
    public MultiOpt10084[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.당일전일
    /// 3.틱분
    /// 4.시간
    /// </summary>
    public override string[] Id => new[] { "종목코드", "당일전일", "틱분", "시간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "당일전일체결요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10084);
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