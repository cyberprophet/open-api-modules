using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증권사별매매상위요청</summary>
public class Opt10039 : TR
{
    /// <summary>증권사별매매상위</summary>
    [DataMember, JsonProperty("증권사별매매상위")]
    public MultiOpt10039[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.회원사코드
    /// 2.거래량구분
    /// 3.매매구분
    /// 4.기간
    /// 5.금액수량구분
    /// </summary>
    public override string[] Id => new[] { "회원사코드", "거래량구분", "매매구분", "기간", "금액수량구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "증권사별매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10039);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "기간중주가등락", "등락율", "기간중거래량", "순매수", "매수거래량", "매도거래량", "순매수금액", "매수금액", "매도금액" };
}