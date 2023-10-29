using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래원매물대분석요청</summary>
public class Opt10043 : TR
{
    /// <summary>거래원매물대분석</summary>
    [DataMember, JsonProperty("거래원매물대분석")]
    public MultiOpt10043[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시작일자
    /// 3.종료일자
    /// 4.조회기간구분
    /// 5.시점구분
    /// 6.기간
    /// 7.정렬기준
    /// 8.회원사코드
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자", "종료일자", "조회기간구분", "시점구분", "기간", "정렬기준", "회원사코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래원매물대분석요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10043);
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
    public override string[] Multiple => new[] { "일자", "종가", "대비기호", "전일대비", "매도량", "매수량", "순매수수량", "거래량합", "거래비중" };
}