using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>장중투자자별매매요청</summary>
public class Opt10063 : TR
{
    /// <summary>장중투자자별매매</summary>
    [DataMember, JsonProperty("장중투자자별매매")]
    public MultiOpt10063[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.금액수량구분
    /// 3.투자자별
    /// 4.외국계전체
    /// 5.동시순매수구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "금액수량구분", "투자자별", "외국계전체", "동시순매수구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "장중투자자별매매요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10063);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "순매수금액", "이전순매수금액", "순매수금액증감", "매수금액", "매수금액증감", "매도금액", "매도금액증감", "순매수수량", "이점시전순매수수량", "순매수증감", "매수수량", "매수수량증감", "매도수량", "매도수량증감" };
}