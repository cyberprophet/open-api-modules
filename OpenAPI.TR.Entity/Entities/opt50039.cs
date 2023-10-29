using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>투자자별포지션종합요청</summary>
public class Opt50039 : TR
{
    /// <summary>투자자별포지션종합</summary>
    [DataMember, JsonProperty("투자자별포지션종합")]
    public MultiOpt50039[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자구분
    /// 2.일자
    /// 3.수량금액구분
    /// 4.단위구분
    /// </summary>
    public override string[] Id => new[] { "일자구분", "일자", "수량금액구분", "단위구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "투자자별포지션종합요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50039);
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
    public override string[] Multiple => new[] { "기간중주가등락", "기타법인", "연기금등", "기타금융", "은행", "투신", "보험", "금융투자", "외국인", "개인", "누적거래량", "미결제약정전일대비", "미결제약정", "대비기호", "전일대비", "등락율", "현재가", "종목코드", "행사가", "지수환산", "대칭구분", "풋_종목코드", "풋_현재가", "풋_등락율", "풋_대비기호", "풋_전일대비", "풋_미결제약정", "풋_미결제약정전일대비", "풋_누적거래량", "풋_ATM구분", "풋_개인", "풋_외국인", "풋_금융투자", "풋_보험", "풋_투신", "풋_은행", "풋_기타금융", "풋_연기금등", "풋_기타법인", "풋_기간중주가등락" };
}