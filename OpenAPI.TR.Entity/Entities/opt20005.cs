using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종분봉조회요청</summary>
public class Opt20005 : TR
{
    /// <summary>업종분봉차트</summary>
    [DataMember, JsonProperty("업종분봉차트")]
    public SingleOpt20005? SingleResponse
    {
        get; set;
    }
    /// <summary>업종분봉조회</summary>
    [DataMember, JsonProperty("업종분봉조회")]
    public MultiOpt20005[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.업종코드
    /// 2.틱범위
    /// </summary>
    public override string[] Id => new[] { "업종코드", "틱범위" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "업종분봉조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opt20005);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "업종코드" };
    public override string[] Multiple => new[] { "현재가", "거래량", "체결시간", "시가", "고가", "저가", "대업종구분", "소업종구분", "종목정보", "전일종가" };
}