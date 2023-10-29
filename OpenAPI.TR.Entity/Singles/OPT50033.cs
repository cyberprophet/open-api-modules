using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵잔존일조회</summary>
public class SingleOPT50033
{
    /// <summary>대표내재변동성</summary>
    [DataMember, JsonProperty("대표내재변동성")]
    public string? RepresentativeInternalVolatility
    {
        get; set;
    }
    /// <summary>콜내재변동성</summary>
    [DataMember, JsonProperty("콜내재변동성")]
    public string? VolatilityInCallVolatility
    {
        get; set;
    }
    /// <summary>풋내재변동성</summary>
    [DataMember, JsonProperty("풋내재변동성")]
    public string? InPutVolatility
    {
        get; set;
    }
    /// <summary>역사적변동성</summary>
    [DataMember, JsonProperty("역사적변동성")]
    public string? HistoricalVolatility
    {
        get; set;
    }
    /// <summary>잔존일수</summary>
    [DataMember, JsonProperty("잔존일수")]
    public string? RemainingDays
    {
        get; set;
    }
    /// <summary>영업일기준잔존일</summary>
    [DataMember, JsonProperty("영업일기준잔존일")]
    public string? RemainingDaysBasedOnBusinessDays
    {
        get; set;
    }
    /// <summary>차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차근달력기준잔존일")]
    public string? RemainingDateBasedOnStepByStepCalendar
    {
        get; set;
    }
    /// <summary>차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차근영업일기준잔존일")]
    public string? StepByStepRemainingDaysBasedOnBusinessDays
    {
        get; set;
    }
    /// <summary>차차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차차근달력기준잔존일")]
    public string? RemainingDateBasedOnTheCalendarStepByStep
    {
        get; set;
    }
    /// <summary>차차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차차근영업일기준잔존일")]
    public string? RemainingDateOfTheBusinessDiaryOfNext
    {
        get; set;
    }
    /// <summary>차차차근달력기준잔존일</summary>
    [DataMember, JsonProperty("차차차근달력기준잔존일")]
    public string? GraduallyTheRemainingDaysBasedOnTheCalendar
    {
        get; set;
    }
    /// <summary>차차차근영업일기준잔존일</summary>
    [DataMember, JsonProperty("차차차근영업일기준잔존일")]
    public string? NextBusinessDiaryRemainingDate
    {
        get; set;
    }
    /// <summary>선물대표내재변동성</summary>
    [DataMember, JsonProperty("선물대표내재변동성")]
    public string? InternalVolatilityInFuturesRepresentation
    {
        get; set;
    }
    /// <summary>선물콜내재변동성</summary>
    [DataMember, JsonProperty("선물콜내재변동성")]
    public string? VolatilityInFuturesCalls
    {
        get; set;
    }
    /// <summary>선물풋내재변동성</summary>
    [DataMember, JsonProperty("선물풋내재변동성")]
    public string? InPutFuturesVolatility
    {
        get; set;
    }
}