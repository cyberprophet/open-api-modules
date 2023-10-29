using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>순매수거래원순위요청</summary>
public class Opt10042 : TR
{
    /// <summary>순매수거래원순위</summary>
    [DataMember, JsonProperty("순매수거래원순위")]
    public MultiOpt10042[]? MultiResponse
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
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자", "종료일자", "조회기간구분", "시점구분", "기간", "정렬기준" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "순매수거래원순위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10042);
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
    public override string[] Multiple => new[] { "순위", "회원사코드", "회원사명" };
}