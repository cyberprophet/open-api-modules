using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵시고저가요청</summary>
public class OPT50003 : TR
{
    /// <summary>선옵시고저가</summary>
    [DataMember, JsonProperty("선옵시고저가")]
    public SingleOPT50003? SingleResponse
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
        get => "선옵시고저가요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50003);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "일자", "현재가", "기준가", "체결량", "시가", "고가", "저가", "시초미결제약정수량", "최고미결제약정수량", "최저미결제약정수량", "미결제약정", "전일미결제약정", "이론가", "내재변동성", "델타", "감마", "상한가", "하한가", "시장베이시스", "괴리율" };
    public override string[] Multiple => Array.Empty<string>();
}