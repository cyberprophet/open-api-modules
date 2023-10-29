using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>풋옵션행사가요청</summary>
public class Opt50065 : TR
{
    /// <summary>풋옵션행사가</summary>
    [DataMember, JsonProperty("풋옵션행사가")]
    public MultiOpt50065[]? MultiResponse
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
        get => "풋옵션행사가요청";
    }
    public override string TrCode
    {
        get => nameof(Opt50065);
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
    public override string[] Multiple => new[] { "종목코드", "ATM구분", "행사가" };
}