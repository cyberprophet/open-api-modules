using ShareInvest;
using ShareInvest.Utilities.Naver;

const string path = @"C:\OpenAPI\data";
const string createPath = @"OpenAPI.TR.Entity\Entities";

using (var papago = new Papago("CyWjKHSLqrbNk9UNwjPF", "6xaEctwkN_"))
{
    await new Install(papago, path, createPath).RunAsync();
}