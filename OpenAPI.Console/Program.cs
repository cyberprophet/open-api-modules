using ShareInvest;
using ShareInvest.Utilities.Naver;

const string path = @"C:\OpenAPI\data";
const string createPath = @"OpenAPI.TR.Entity\Entities";

using (var papago = new Papago("YOUR-CLIENT-ID", "YOUR-CLIENT-SECRET"))
{
    await new Install(papago, path, createPath).RunAsync();
}