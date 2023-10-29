using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>가격급등락요청</summary>
public class Opt10019 : TR
{
    /// <summary>가격급등락</summary>
    [DataMember, JsonProperty("가격급등락")]
    public MultiOpt10019[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.등락구분
    /// 3.시간구분
    /// 4.시간
    /// 5.거래량구분
    /// 6.종목조건
    /// 7.신용조건
    /// 8.가격조건
    /// 9.상하한포함
    /// </summary>
    public override string[] Id => new[] { "시장구분", "등락구분", "시간구분", "시간", "거래량구분", "종목조건", "신용조건", "가격조건", "상하한포함" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "가격급등락요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10019);
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
    public override string[] Multiple => new[] { "종목코드", "종목분류", "종목명", "전일대비기호", "전일대비", "등락률", "기준가", "현재가", "기준대비", "거래량", "급등률" };
}