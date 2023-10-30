namespace ShareInvest;

public class AxErrCodeEventArgs : EventArgs
{
    public string? RQName
    {
        get;
    }
    public int ErrorCode
    {
        get;
    }
    public AxErrCodeEventArgs(string? sRQName, int errCode)
    {
        RQName = sRQName;
        ErrorCode = errCode;
    }
}