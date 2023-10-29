using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별기관매매추이요청</summary>
public class Opt10045 : TR
{
    /// <summary>기관추정평균가</summary>
    [DataMember, JsonProperty("기관추정평균가")]
    public SingleOpt10045? SingleResponse
    {
        get; set;
    }
    /// <summary>종목별기관매매추이</summary>
    [DataMember, JsonProperty("종목별기관매매추이")]
    public MultiOpt10045[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시작일자
    /// 3.종료일자
    /// 4.기관추정단가구분
    /// 5.외인추정단가구분
    /// 6.누적기간
    /// 7.기간구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시작일자", "종료일자", "기관추정단가구분", "외인추정단가구분", "누적기간", "기간구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목별기관매매추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10045);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "기관추정평균가", "외인추정평균가" };
    public override string[] Multiple => new[] { "일자", "종가", "대비기호", "전일대비", "등락율", "거래량", "기관기간누적", "기관일별순매매수량", "외인기간누적", "외인일별순매매수량", "한도소진율" };
}