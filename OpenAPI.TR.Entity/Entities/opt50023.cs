using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>민감도지표추이요청</summary>
public class Opt50023 : TR
{
    /// <summary>민감도지표추이단일</summary>
    [DataMember, JsonProperty("민감도지표추이단일")]
    public SingleOpt50023? SingleResponse
    {
        get; set;
    }
    /// <summary>민감도지표추이</summary>
    [DataMember, JsonProperty("민감도지표추이")]
    public MultiOpt50023[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.시간구분
    /// </summary>
    public override string[] Id => new[] { "종목코드", "시간구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "민감도지표추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50023);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "이론가", "괴리율", "내재변동성", "시장베이시스", "델타", "베가", "감마", "로", "종목코드", "종목명", "현재가", "대비기호", "전일대비", "등락율", "누적거래량", "누적거래대금", "고가", "저가", "종목표준코드", "내재가치", "시간가치" };
    public override string[] Multiple => new[] { "일자", "체결시간", "현재가n", "이론가n", "내재변동성n", "델타n", "감마n", "세타n", "베가n", "로n", "시가", "고가n", "저가n", "대비기호n", "전일대비n", "등락율n", "누적거래량n", "미결제약정n" };
}