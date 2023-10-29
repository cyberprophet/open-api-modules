using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>공매도추이요청</summary>
public class Opt10014 : TR
{
    /// <summary>공매도추이</summary>
    [DataMember, JsonProperty("공매도추이")]
    public MultiOpt10014[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간구분
    /// 3.시작일자
    /// 4.종료일자
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간구분", "시작일자", "종료일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "공매도추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10014);
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
    public override string[] Multiple => new[] { "일자", "종가", "전일대비기호", "전일대비", "등락율", "거래량", "공매도량", "매매비중", "공매도거래대금", "공매도평균가" };
}