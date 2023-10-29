using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별증권사순위요청</summary>
public class Opt10038 : TR
{
    /// <summary>종목별증권사순위_합산</summary>
    [DataMember, JsonProperty("종목별증권사순위_합산")]
    public SingleOpt10038? SingleResponse
    {
        get; set;
    }
    /// <summary>종목별증권사순위</summary>
    [DataMember, JsonProperty("종목별증권사순위")]
    public MultiOpt10038[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시작일자
    /// 3.종료일자
    /// 4.조회구분
    /// 5.기간
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자", "종료일자", "조회구분", "기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목별증권사순위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10038);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "순위1", "순위2", "순위3", "기간중거래량" };
    public override string[] Multiple => new[] { "순위", "회원사명", "매수수량", "매도수량", "누적순매수수량" };
}