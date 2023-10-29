using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>일별추정예탁자산현황요청</summary>
public class OPW00002 : TR
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public SingleOPW00002? SingleResponse
    {
        get; set;
    }
    /// <summary>일별추정예탁자산현황</summary>
    [DataMember, JsonProperty("일별추정예탁자산현황")]
    public MultiOPW00002[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.시작조회기간
    /// 4.종료조회기간
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "시작조회기간", "종료조회기간" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "일별추정예탁자산현황요청";
    }
    public override string TrCode
    {
        get => nameof(OPW00002);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "출력건수" };
    public override string[] Multiple => new[] { "일자", "예수금", "담보대출금", "신용융자금", "대주담보금", "대용금", "추정예탁자산", "추정예탁자산수익증권제외" };
}