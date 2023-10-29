using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>동일순매매순위요청</summary>
public class Opt10062 : TR
{
    /// <summary>동일순매매순위</summary>
    [DataMember, JsonProperty("동일순매매순위")]
    public MultiOpt10062[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시작일자
    /// 2.종료일자
    /// 3.시장구분
    /// 4.매매구분
    /// 5.정렬조건
    /// 6.단위구분
    /// </summary>
    public override string[] Id => new[] { "시작일자", "종료일자", "시장구분", "매매구분", "정렬조건", "단위구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "동일순매매순위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10062);
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
    public override string[] Multiple => new[] { "종목코드", "순위", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "기관순매매수량", "기관순매매금액", "기관순매매평균가", "외인순매매수량", "외인순매매금액", "외인순매매평균가", "순매매수량", "순매매금액" };
}