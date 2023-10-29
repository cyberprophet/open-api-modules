using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>상하한가요청</summary>
public class Opt10017 : TR
{
    /// <summary>상하한가</summary>
    [DataMember, JsonProperty("상하한가")]
    public MultiOpt10017[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.상하한구분
    /// 3.정렬구분
    /// 4.종목조건
    /// 5.거래량구분
    /// 6.신용조건
    /// 7.매매금구분
    /// </summary>
    public override string[] Id => new[] { "시장구분", "상하한구분", "정렬구분", "종목조건", "거래량구분", "신용조건", "매매금구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "상하한가요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10017);
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
    public override string[] Multiple => new[] { "종목코드", "종목정보", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "거래량", "전일거래량", "매도잔량", "매도호가", "매수호가", "매수잔량", "횟수" };
}