using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>신용융자 가능종목요청</summary>
public class Opw20016 : TR
{
    /// <summary>신용융자가능여부</summary>
    [DataMember, JsonProperty("신용융자가능여부")]
    public SingleOpw20016? SingleResponse
    {
        get; set;
    }
    /// <summary>신용융자가능종목</summary>
    [DataMember, JsonProperty("신용융자가능종목")]
    public MultiOpw20016[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.신용종목등급구분
    /// 2.시장거래구분
    /// 3.종목번호
    /// </summary>
    public override string[] Id => new[] { "신용종목등급구분", "시장거래구분", "종목번호" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "신용융자 가능종목요청";
    }
    public override string TrCode
    {
        get => nameof(Opw20016);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "신용융자가능여부", "출력건수" };
    public override string[] Multiple => new[] { "종목코드", "종목명", "신용보즘금율", "대용가", "전일종가", "신용한도초과여부", "신용한도초과" };
}