using System.Text.RegularExpressions;

namespace ShareInvest;

static partial class Transform
{
    internal static string TransformInbound(string? query)
    {
        if (string.IsNullOrEmpty(query) is false)
        {
            var str = TransformRegex().Replace(query, o => o.Groups[1].Value.ToUpper());

            return string.Concat(char.ToUpper(str[0]), str[1..]);
        }
        return string.Empty;
    }
    [GeneratedRegex(" ([a-z])")]
    private static partial Regex TransformRegex();
}