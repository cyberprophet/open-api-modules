using Newtonsoft.Json;

using RestSharp;

namespace ShareInvest;

class Geolocation : RestClient
{
    internal async Task ExecutePostAsync(string resource)
    {
        var request = new RestRequest(resource, Method.Post);

        var json = JsonConvert.SerializeObject(new
        {
            considerIp = false,
            wifiAccessPoints = new[]
            {
                new
                {
                    macAddress = "3c:37:86:5d:75:d4",
                    signalStrength = -35,
                    signalToNoiseRatio = 0
                },
                new
                {
                    macAddress = "94:b4:0f:fd:c1:40",
                    signalStrength = -35,
                    signalToNoiseRatio = 0
                }
            }
        });
        var res = await ExecuteAsync(request.AddJsonBody(json), cts.Token);

        Console.WriteLine(res);
    }
    internal Geolocation(string baseUrl) : base(baseUrl)
    {

    }
    readonly CancellationTokenSource cts = new();
}