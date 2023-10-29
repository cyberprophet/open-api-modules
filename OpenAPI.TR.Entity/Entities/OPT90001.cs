using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>테마그룹별요청</summary>
public class OPT90001 : TR
{
    /// <summary>테마그룹별</summary>
    [DataMember, JsonProperty("테마그룹별")]
    public MultiOPT90001[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.검색구분
    /// 2.종목코드
    /// 3.날짜구분
    /// 4.테마명
    /// 5.등락수익구분
    /// </summary>
    public override string[] Id => new[] { "검색구분", "종목코드", "날짜구분", "테마명", "등락수익구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "테마그룹별요청";
    }
    public override string TrCode
    {
        get => nameof(OPT90001);
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
    public override string[] Multiple => new[] { "종목코드", "테마명", "종목수", "등락기호", "등락율", "상승종목수", "하락종목수", "기간수익률", "주요종목" };
}