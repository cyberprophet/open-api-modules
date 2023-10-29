using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선물옵션현재가정보요청</summary>
public class OPT50019 : TR
{
    /// <summary>선물옵션현재가정보</summary>
    [DataMember, JsonProperty("선물옵션현재가정보")]
    public SingleOPT50019? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// </summary>
    public override string[] Id => new[] { "종목코드" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선물옵션현재가정보요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50019);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "종목명", "현재가", "대비기호", "전일대비", "내재가치", "시간가치", "이론가", "시가", "고가", "저가", "누적거래량", "거래량전일대비", "누적거래대금", "거래대금증감", "미결제약정", "미결제약정전일대비", "역사적변동성", "표면이자", "배당액지수", "매도호가", "매도수량", "매수호가", "매수수량" };
    public override string[] Multiple => Array.Empty<string>();
}