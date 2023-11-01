using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일봉차트조회요청</summary>
public class Opt10081 : TR
{
    /// <summary>주식일봉차트</summary>
    [DataMember, JsonProperty("주식일봉차트")]
    public SingleOpt10081? SingleResponse
    {
        get; set;
    }
    /// <summary>주식일봉차트조회</summary>
    [DataMember, JsonProperty("주식일봉차트조회")]
    public MultiOpt10081[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[]
    {
        "종목코드",
        "기준일자",
        "수정주가구분"
    };
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
    /// 3.수정주가구분
    /// </summary>
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "주식일봉차트조회요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10081);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[]
    {
        "종목코드"
    };
    public override string[] Multiple => new[]
    {
        "종목코드",
        "현재가",
        "거래량",
        "거래대금",
        "일자",
        "시가",
        "고가",
        "저가",
        "수정주가구분",
        "수정비율",
        "대업종구분",
        "소업종구분",
        "종목정보",
        "수정주가이벤트",
        "전일종가"
    };
}