using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>변동성완화장치발동종목요청</summary>
public class Opt10054 : TR
{
    /// <summary>발동종목</summary>
    [DataMember, JsonProperty("발동종목")]
    public MultiOpt10054[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.장전구분
    /// 3.종목코드
    /// 4.발동구분
    /// 5.제외종목
    /// 6.거래량구분
    /// 7.최소거래량
    /// 8.최대거래량
    /// 9.거래대금구분
    /// 10.최소거래대금
    /// 11.최대거래대금
    /// 12.발동방향
    /// </summary>
    public override string[] Id => new[] { "시장구분", "장전구분", "종목코드", "발동구분", "제외종목", "거래량구분", "최소거래량", "최대거래량", "거래대금구분", "최소거래대금", "최대거래대금", "발동방향" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "변동성완화장치발동종목요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10054);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "누적거래량", "발동가격", "동적괴리율", "매매체결처리시각", "VI해제시각", "VI적용구분", "동적기준가격", "정적기준가격", "정적괴리율", "시가대비등락률", "VI발동횟수" };
}