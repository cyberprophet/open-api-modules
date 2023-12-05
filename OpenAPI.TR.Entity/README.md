# [![NuGet](https://img.shields.io/nuget/v/ShareInvest.OpenAPI.TR.Entity?label=ShareInvest.OpenAPI.TR.Entity&style=plastic&logo=nuget&color=004880)](https://www.nuget.org/packages/ShareInvest.OPENAPI.TR.Entity)
### · Implemented as [![Platform](https://img.shields.io/nuget/v/Microsoft.NETCore.Platforms?label=CSharp&style=plastic&logo=.NET&color=512BD4)](https://versionsof.net) using [![IDE](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=plastic&logoColor=white&logo=visualstudio)](https://learn.microsoft.com/en-us/visualstudio/releases/2022).
```C#
namespace ShareInvest.OpenAPI.Entity
{
    public abstract class TR
    {
        public abstract string[] Id
        {
            get;
        }
        public abstract string[]? Value
        {
            get; set;
        }
        public abstract string? RQName
        {
            get; set;
        }
        public abstract string TrCode
        {
            get;
        }
        public abstract int PrevNext
        {
            get; set;
        }
        public abstract string ScreenNo
        {
            get;
        }
        public abstract string[] Single
        {
            get;
        }
        public abstract string[] Multiple
        {
            get;
        }
        protected internal virtual string LookupScreenNo
        {
            get
            {
                if (count++ == 0x95)
                {
                    count = 0;
                }
                return (3000 + count).ToString("D4");
            }
        }
        static uint count;
    }
}
```
### · Objects for convenient use of OpenAPI's TR data for Kiwoom Securities Corp.
