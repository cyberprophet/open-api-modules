using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일자별종목별실현손익요청</summary>
public class Opt10073 : TR
{
    /// <summary>일자별종목별실현손익</summary>
    [DataMember, JsonProperty("일자별종목별실현손익")]
    public MultiOpt10073[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.종목코드
    /// 3.시작일자
    /// 4.종료일자
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "종목코드", "시작일자", "종료일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일자별종목별실현손익요청";
    }
    public override string TrCode
    {
        get => nameof(Opt10073);
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
    public override string[] Multiple => new[] { "일자", "당일hts매도수수료", "종목명", "체결량", "매입단가", "체결가", "당일매도손익", "손익율", "종목코드", "당일매매수수료", "당일매매세금", "인출가능금액", "대출일", "신용구분" };
}