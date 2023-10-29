using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>외국인기관매매상위요청</summary>
public class Opt90009 : TR
{
    /// <summary>외국인기관매매상위</summary>
    [DataMember, JsonProperty("외국인기관매매상위")]
    public MultiOpt90009[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.금액수량구분
    /// 3.조회일자구분
    /// 4.날짜
    /// </summary>
    public override string[] Id => new[] { "시장구분", "금액수량구분", "조회일자구분", "날짜" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "외국인기관매매상위요청";
    }
    public override string TrCode
    {
        get => nameof(Opt90009);
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
    public override string[] Multiple => new[] { "외인순매도종목코드", "외인순매도종목명", "외인순매도금액", "외인순매도수량", "대칭구분", "외인순매수종목코드", "외인순매수종목명", "외인순매수금액", "외인순매수수량", "대칭구분", "기관순매도종목코드", "기관순매도종목명", "기관순매도금액", "기관순매도수량", "대칭구분", "기관순매수종목코드", "기관순매수종목명", "기관순매수금액", "기관순매수수량" };
}