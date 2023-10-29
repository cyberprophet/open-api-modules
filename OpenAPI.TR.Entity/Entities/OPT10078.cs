using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>증권사별종목매매동향요청</summary>
public class OPT10078 : TR
{
    /// <summary>증권사별종목매매동향</summary>
    [DataMember, JsonProperty("증권사별종목매매동향")]
    public MultiOPT10078[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.회원사코드
    /// 2.종목코드
    /// 3.시작일자
    /// 4.종료일자
    /// </summary>
    public override string[] Id => new[] { "회원사코드", "종목코드", "시작일자", "종료일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "증권사별종목매매동향요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10078);
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
    public override string[] Multiple => new[] { "일자", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "순매수수량", "매수수량", "매도수량" };
}