using RestSharp;

namespace ShareInvest;

class AnTalkClient : RestClient
{
    internal async Task<RestResponse> ExecuteAsync<T>(T obj) where T : class
    {
        var request = new RestRequest
        {
            Resource = Parameter.TransformOutbound(obj.GetType().Name),
            Method = Method.Post
        };
        return await ExecuteAsync(request.AddJsonBody(obj), cts.Token);
    }
    internal AnTalkClient(string baseUrl, string? accessToken) : base(baseUrl, configureDefaultHeaders: headers =>
    {
        headers.Add(KnownHeaders.Authorization, $"Bearer {accessToken}");
    })
    {

    }
    readonly CancellationTokenSource cts = new();
}