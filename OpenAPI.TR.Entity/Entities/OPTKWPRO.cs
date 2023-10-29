using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목프로그램정보요청</summary>
public class OPTKWPRO : TR
{
    /// <summary>관심종목프로그램정보</summary>
    [DataMember, JsonProperty("관심종목프로그램정보")]
    public MultiOPTKWPRO[]? MultiResponse
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
        get => "관심종목프로그램정보요청";
    }
    public override string TrCode
    {
        get => nameof(OPTKWPRO);
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
    public override string[] Multiple => new[] { "차익매도량", "차익매도대금", "차익매도비율", "차익매수량", "차익매수대금", "차익매수비율", "차익순매수금액", "비차익매도량", "비차익매도대금", "비차익매도비율", "비차익매수량", "비차익매수대금", "비차익매수비율", "비차익순매수금액", "합계매도량", "합계매도대금", "합계매수량", "합계매수대금", "합계순매수" };
}