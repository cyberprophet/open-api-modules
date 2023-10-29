using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵당일매매변동현황요청</summary>
public class OPW20002 : TR
{
    /// <summary>선옵당일매매변동현황</summary>
    [DataMember, JsonProperty("선옵당일매매변동현황")]
    public SingleOPW20002? SingleResponse
    {
        get; set;
    }
    /// <summary>
    /// 1.계좌번호
    /// 2.비밀번호
    /// 3.시장구분
    /// 4.체결일자
    /// 5.비밀번호입력매체구분
    /// </summary>
    public override string[] Id => new[] { "계좌번호", "비밀번호", "시장구분", "체결일자", "비밀번호입력매체구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "선옵당일매매변동현황요청";
    }
    public override string TrCode
    {
        get => nameof(OPW20002);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => new[] { "선물수수료", "옵션수수료", "주식옵션수수료", "선물매도수량", "선물매도금액", "선물매도평균가격", "선물매수수량", "선물매수금액", "선물매수평균가격", "선물전매수량", "선물전매금액", "선물환매수량", "선물환매금액", "콜매도수량", "콜매도금액", "콜매도평균가격", "콜매수수량", "콜매수금액", "콜매수평균가격", "콜전매수량", "콜전매금액", "콜환매수량", "콜환매금액", "풋매도수량", "풋매도금액", "풋매도평균가격", "풋매수수량", "풋매수금액", "풋매수평균가격", "풋전매수량", "풋전매금액", "풋환매수량", "풋환매금액", "선물최종매도수량", "선물최종매도금액", "선물최종매도평균가격", "선물최종매수수량", "선물최종매수금액", "선물최종매수평균가격", "콜권리행사수량", "콜권리행사금액", "콜권리행사가격", "풋권리행사수량", "풋권리행사금액", "풋권리행사가격", "콜권리배정수량", "콜권리배정금액", "콜권리배정가격", "풋권리배정수량", "풋권리배정금액", "풋권리배정가격" };
    public override string[] Multiple => Array.Empty<string>();
}