using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신고저가요청</summary>
public class OPT10016 : TR
{
    /// <summary>신고저가</summary>
    [DataMember, JsonProperty("신고저가")]
    public MultiOPT10016[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.신고저구분
    /// 3.고저종구분
    /// 4.종목조건
    /// 5.거래량구분
    /// 6.신용조건
    /// 7.상하한포함
    /// 8.기간
    /// </summary>
    public override string[] Id => new[] { "시장구분", "신고저구분", "고저종구분", "종목조건", "거래량구분", "신용조건", "상하한포함", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신고저가요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10016);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "거래량", "전일거래량대비율", "매도호가", "매수호가", "고가", "저가" };
}