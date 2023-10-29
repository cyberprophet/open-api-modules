using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>풋종목결제월별시세요청</summary>
public class OPT50022 : TR
{
    /// <summary>풋종목결제월별시세</summary>
    [DataMember, JsonProperty("풋종목결제월별시세")]
    public MultiOPT50022[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.만기년월
    /// </summary>
    public override string[] Id => new[] { "만기년월" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "풋종목결제월별시세요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50022);
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
    public override string[] Multiple => new[] { "지수환산", "ATM구분", "종목코드", "행사가", "현재가", "대비기호", "전일대비", "등락율", "시가", "기준가대비시가등락율", "고가", "기준가대비고가등락율", "저가", "기준가대비저가등락율", "기준가", "매도호가", "매도호가수량", "매수호가", "매수호가수량", "매도호가총잔량", "매수호가총잔량", "누적거래량", "누적거래대금", "미결제약정", "미결제약정전일대비", "괴리율", "이론가", "내재변동성", "내재가치", "시간가치", "델타", "감마", "세타", "베가", "로" };
}