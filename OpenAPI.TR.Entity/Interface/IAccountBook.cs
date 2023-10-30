namespace ShareInvest.OpenAPI.Entity;

public interface IAccountBook
{
    string? AccNo
    {
        get; set;
    }
    string? Date
    {
        get; set;
    }
    long Lookup
    {
        get; set;
    }
}