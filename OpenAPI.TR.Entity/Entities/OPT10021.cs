using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>호가잔량급증요청</summary>
public class OPT10021 : TR
{
    /// <summary>호가잔량급증</summary>
    [DataMember, JsonProperty("호가잔량급증")]
    public MultiOPT10021[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.시장구분
    /// 2.매매구분
    /// 3.정렬구분
    /// 4.시간구분
    /// 5.거래량구분
    /// 6.종목조건
    /// </summary>
    public override string[] Id => new[] { "시장구분", "매매구분", "정렬구분", "시간구분", "거래량구분", "종목조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "호가잔량급증요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10021);
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
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "기준률", "현재", "급증수량", "급증률", "총매수량" };
}