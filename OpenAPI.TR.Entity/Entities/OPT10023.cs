using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>거래량급증요청</summary>
public class OPT10023 : TR
{
    /// <summary>거래량급증</summary>
    [DataMember, JsonProperty("거래량급증")]
    public MultiOPT10023[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[] { "시장구분", "정렬구분", "시간구분", "거래량구분", "시간", "종목조건", "가격구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "거래량급증요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10023);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "등락률", "이전거래량", "현재거래량", "급증량", "급증률" };
}