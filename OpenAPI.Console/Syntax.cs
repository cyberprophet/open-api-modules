using System.Text;

namespace ShareInvest;

static class Syntax
{
    internal static string[] GetKeyNames(string str)
    {
        var sections = new Queue<string>();

        foreach (var line in str.Split("\r\n", StringSplitOptions.RemoveEmptyEntries))
        {
            int pos = line.IndexOf('=');

            if (pos != -1)
            {
                sections.Enqueue(line[..pos].Trim());
            }
        }
        return sections.ToArray();
    }
    internal static string CreateNamespace()
    {
        return $"using Newtonsoft.Json;" +
               $"\r\nusing System.Runtime.Serialization;\r\n" +
               $"\r\nnamespace ShareInvest.OpenAPI.Entity;";
    }
    internal static string CreateClass(string className, string classExplanation)
    {
        return $"\r\n\r\n/// <summary>{classExplanation}</summary>" +
               $"\r\npublic class {className}: TR{{";
    }
    internal static string CreateSingleResponseClass(string className, string classExplanation)
    {
        return $"\r\n\r\n/// <summary>{classExplanation}</summary>" +
               $"\r\n  public class Single{className}{{";
    }
    internal static string CreateMultiResponseClass(string className, string classExplanation)
    {
        return $"\r\n\r\n/// <summary>{classExplanation}</summary>" +
               $"\r\npublic class Multi{className}{{";
    }
    internal static string CreateSingleResponse(string className, string singleName)
    {
        return $"\r\n/// <summary>{singleName}</summary>\r\n" +
               $"[DataMember, JsonProperty(\"{singleName}\")]\r\npublic Single{className}? SingleResponse{{ get; set; }}";
    }
    internal static string CreateMultiResponse(string className, string multiName)
    {
        return $"\r\n/// <summary>{multiName}</summary>\r\n" +
               $"[DataMember, JsonProperty(\"{multiName}\")]public Multi{className}[]? MultiResponse{{ get; set; }}";
    }
    internal static string CreateProperty(string propertyName, string translatedName)
    {
        return $"\r\n/// <summary>{propertyName}</summary>\r\n" +
               $"[DataMember, JsonProperty(\"{propertyName}\")]\r\npublic string? {translatedName}{{ get; set; }}";
    }
    internal static string CreateProperty(string[] trInput, string trName, string className, string[] single, string[] multi)
    {
        StringBuilder inputSb = new(string.Empty), singleSb = new(string.Empty), multiSb = new(string.Empty);

        for (int i = 0; i < multi.Length; i++)
        {
            multiSb.Append('"');
            multiSb.Append(multi[i]);
            multiSb.Append('"');

            if (i == multi.Length - 1)
            {
                break;
            }
            multiSb.Append(',');
        }
        for (int i = 0; i < single.Length; i++)
        {
            singleSb.Append('"');
            singleSb.Append(single[i]);
            singleSb.Append('"');

            if (i == single.Length - 1)
            {
                break;
            }
            singleSb.Append(',');
        }
        for (int i = 0; i < trInput.Length; i++)
        {
            inputSb.Append('"');
            inputSb.Append(trInput[i]);
            inputSb.Append('"');

            if (i == trInput.Length - 1)
            {
                break;
            }
            inputSb.Append(',');
        }
        return $"{CreateSummary(trInput)}public override string[] Id => {DetermineIfTheSyntaxIsCorrect(trInput.Length == 0, inputSb)}" +
               "\r\n    public override string[]? Value\r\n    {\r\n        get; set;\r\n    }\r\n" +
               $"    public override string? RQName\r\n    {{\r\n        set\r\n        {{\r\n\r\n        }}\r\n        get => \"{trName}\";" +
               "\r\n    }\r\n    public override string TrCode\r\n    {\r\n        get => " +
               $"nameof({className});\r\n" +
               "    }\r\n    public override int PrevNext\r\n    {\r\n        get; set;\r\n    }\r\n    public override string ScreenNo\r\n    {\r\n        get => LookupScreenNo;\r\n    }\r\n" +
               $"    public override string[] Single => {DetermineIfTheSyntaxIsCorrect(single.Length == 0, singleSb)}" +
               $"\r\n    public override string[] Multiple => {DetermineIfTheSyntaxIsCorrect(multi.Length == 0, multiSb)}";
    }
    static string DetermineIfTheSyntaxIsCorrect(bool isCorrect, StringBuilder sb)
    {
        return isCorrect ? "Array.Empty<string>();" : $"new[]{{ {sb}}};";
    }
    static string CreateSummary(string[] trInput)
    {
        StringBuilder sb = new($"\r\n/// <summary>");

        for (int i = 0; i < trInput.Length; i++)
        {
            sb.Append("\r\n/// ");
            sb.Append($"{i + 1}.{trInput[i]}");
        }
        return trInput.Length > 0 ? sb.Append("\r\n/// </summary>\r\n").ToString() : string.Empty;
    }
}