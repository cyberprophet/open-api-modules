using AxKHOpenAPILib;

using System.Globalization;

namespace ShareInvest.Transmission;

abstract class Constructor
{
    protected internal static CultureInfo Culture
    {
        get => new("ko-KR");
    }
    internal string[]? Multiple
    {
        get; set;
    }
    internal string[]? Single
    {
        get; set;
    }
    internal string[]? Value
    {
        get; set;
    }
    internal string[]? Id
    {
        get; set;
    }
    internal abstract IEnumerable<string> OnReceiveTrData(AxKHOpenAPI axAPI, _DKHOpenAPIEvents_OnReceiveTrDataEvent e);
}