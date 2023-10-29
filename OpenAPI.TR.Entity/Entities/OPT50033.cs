using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔존일조회요청</summary>
public class OPT50033 : TR
{
    /// <summary>선옵잔존일조회</summary>
    [DataMember, JsonProperty("선옵잔존일조회")]
    public SingleOPT50033? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.종목코드
    /// 2.기준일자
    /// </summary>
    public override string[] Id => new[] { "종목코드", "기준일자" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵잔존일조회요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50033);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "대표내재변동성", "콜내재변동성", "풋내재변동성", "역사적변동성", "잔존일수", "영업일기준잔존일", "차근달력기준잔존일", "차근영업일기준잔존일", "차차근달력기준잔존일", "차차근영업일기준잔존일", "차차차근달력기준잔존일", "차차차근영업일기준잔존일", "선물대표내재변동성", "선물콜내재변동성", "선물풋내재변동성" };
    public override string[] Multiple => Array.Empty<string>();
}