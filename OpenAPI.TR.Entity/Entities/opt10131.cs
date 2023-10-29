using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>기관외국인연속매매현황요청</summary>
public class Opt10131 : TR
{
    /// <summary>기관외국인연속매매현황</summary>
    [DataMember, JsonProperty("기관외국인연속매매현황")]
    public MultiOpt10131[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.기간
    /// 2.시작일자
    /// 3.종료일자
    /// 4.장구분
    /// 5.순매도수구분
    /// 6.종목업종구분
    /// 7.금액수량구분
    /// </summary>
    public override string[] Id => new[] { "기간", "시작일자", "종료일자", "장구분", "순매도수구분", "종목업종구분", "금액수량구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "기관외국인연속매매현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10131);
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
    public override string[] Multiple => new[] { "순위", "종목코드", "종목명", "기간중주가등락률", "기관순매매금액", "기관순매매량", "기관계연속순매수일수", "기관계연속순매수량", "기관계연속순매수금액", "외국인순매매량", "외국인순매매액", "외국인연속순매수일수", "외국인연속순매수량", "외국인연속순매수금액", "순매매량", "순매매액", "합계연속순매수일수", "합계연속순매매수량", "합계연속순매수금액" };
}