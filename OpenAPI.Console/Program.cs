using ShareInvest;

/*
using ShareInvest.Utilities.Naver;

const string path = @"C:\OpenAPI\data";
const string createPath = @"OpenAPI.TR.Entity\Entities";

using (var papago = new Papago("YOUR-CLIENT-ID", "YOUR-CLIENT-SECRET"))
{
    await new Install(papago, path, createPath).RunAsync();
}
*/
while (RequestLimit.CheckAndResetLimits() == 0)
{
    await Task.Delay(128);
}
var result = RequestLimit.GetDelaySeconds();

Console.WriteLine(new
{
    result.requestCount,
    result.delayTime
});
await Task.Delay(result.delayTime);

while (RequestLimit.CheckAndResetLimits() == 0)
{
    await Task.Delay(256);
}
result = RequestLimit.GetDelayMinute();

Console.WriteLine(new
{
    result.requestCount,
    result.delayTime
});
await Task.Delay(result.delayTime);

Console.ReadLine();
