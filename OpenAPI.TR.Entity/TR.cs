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