using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>차익잔고현황요청</summary>
public class Opt90011 : TR
{
    /// <summary>기준일자</summary>
    [DataMember, JsonProperty("기준일자")]
    public SingleOpt90011? SingleResponse
    {
        get; set;
    }
    /// <summary>차익잔고현황</summary>
    [DataMember, JsonProperty("차익잔고현황")]
    public MultiOpt90011[]? MultiResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.일자
    /// 2.금액수량구분
    /// </summary>
    public override string[] Id => new[] { "일자", "금액수량구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "차익잔고현황요청";
    }
    public override string TrCode
    {
        get => nameof(Opt90011);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "기준일자" };
    public override string[] Multiple => new[] { "종목코드1", "차익매도위탁금액", "차익매수위탁금액", "차익매도위탁선물금액", "차익매수위탁선물금액", "차익매도위탁CALL금액", "차익매수위탁CALL금액", "차익매도위탁PUT금액", "차익매수위탁PUT금액", "차익매도자기금액", "차익매수자기금액", "차익매도자기선물금액", "차익매수자기선물금액", "차익매도자기CALL금액", "차익매수자기CALL금액", "차익매도자기PUT금액", "차익매수자기PUT금액", "차익매도금액", "차익매수금액", "차익매도선물금액", "차익매수선물금액", "차익매도CALL금액", "차익매수CALL금액", "차익매도PUT금액", "차익매수PUT금액", "종목코드2", "차익매도위탁금액2", "차익매수위탁금액2", "차익매도위탁선물금액2", "차익매수위탁선물금액2", "차익매도위탁CALL금액2", "차익매수위탁CALL금액2", "차익매도위탁PUT금액2", "차익매수위탁PUT금액2", "차익매도자기금액2", "차익매수자기금액2", "차익매도자기선물금액2", "차익매수자기선물금액2", "차익매도자기CALL금액2", "차익매수자기CALL금액2", "차익매도자기PUT금액2", "차익매수자기PUT금액2", "차익매도금액2", "차익매수금액2", "차익매도선물금액2", "차익매수선물금액2", "차익매도CALL금액2", "차익매수CALL금액2", "차익매도PUT금액2", "차익매수PUT금액2" };
}