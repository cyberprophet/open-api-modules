using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵계좌예비증거금상세요청</summary>
public class OPW20011 : TR
{
    /// <summary>출력건수</summary>
    [DataMember, JsonProperty("출력건수")]
    public SingleOPW20011? SingleResponse
    {
        get; set;
    }
    /// <summary>선옵계좌예비증거금상세</summary>
    [DataMember, JsonProperty("선옵계좌예비증거금상세")]
    public MultiOPW20011[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.증거금구분
    /// 4.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "증거금구분", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵계좌예비증거금상세요청";
    }
    public override string TrCode
    {
        get => nameof(OPW20011);
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
    public override string[] Multiple => new[] { "기초자산명", "최대구간증거금", "증거금감면액", "구간증거금01", "구간증거금02", "구간증거금03", "구간증거금04", "구간증거금05", "구간증거금06", "구간증거금07", "구간증거금08", "구간증거금09", "구간증거금10", "구간증거금11", "구간증거금12", "구간증거금13", "구간증거금14", "구간증거금15", "구간증거금16", "구간증거금17", "구간증거금18", "구간증거금19", "구간증거금20", "구간증거금21", "구간증거금22", "구간증거금23", "구간증거금24", "구간증거금25", "구간증거금26", "구간증거금27", "구간증거금28", "구간증거금29", "구간증거금30", "구간증거금31", "구간증거금32", "구간증거금33", "구간증거금34", "구간증거금35", "구간증거금36", "구간증거금37", "구간증거금38", "구간증거금39", "구간증거금40", "구간증거금41", "구간증거금42", "구간증거금43", "구간증거금44", "구간증거금45", "구간증거금46", "구간증거금47", "구간증거금48", "구간증거금49", "구간증거금50", "구간증거금51", "구간증거금52", "구간증거금53", "구간증거금54", "구간증거금55", "구간증거금56", "구간증거금57", "구간증거금58", "구간증거금59", "구간증거금60", "구간증거금61", "구간증거금62" };
}