using System.IO.Compression;
using System.Text;

const string path = "C:\\OpenAPI\\data";
const string createPath = "C:\\Users\\cyber\\Source\\Repos\\OpenAPI\\OpenAPI.TR.Entity\\Entities";

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

static string[] GetKeyNames(string str)
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
static string CreateClass(string className, string singleName, string? multiName)
{
    if (string.IsNullOrEmpty(multiName))
    {
        return $"using Newtonsoft.Json;" +
               $"\r\nusing System.Runtime.Serialization;" +
               $"\r\nnamespace ShareInvest.OpenAPI.Entity;" +
               $"\r\n\r\npublic class {className}: TR" +
               $"{{" +
               $"[DataMember, JsonProperty(\"{singleName}\")]" +
               $"public Single{className}? SingleResponse" +
               $"{{ get; set; }}" +
               $"}}";
    }
    if (string.IsNullOrEmpty(singleName))
    {
        return $"using Newtonsoft.Json;" +
               $"\r\nusing System.Runtime.Serialization;" +
               $"\r\nnamespace ShareInvest.OpenAPI.Entity;" +
               $"\r\n\r\npublic class {className}: TR" +
               $"{{" +
               $"[DataMember, JsonProperty(\"{multiName}\")]" +
               $"public Multi{multiName}[]? MultiResponse" +
               $"{{ get; set; }}" +
               $"}}";
    }
    return $"using Newtonsoft.Json;" +
           $"\r\nusing System.Runtime.Serialization;" +
           $"\r\nnamespace ShareInvest.OpenAPI.Entity;" +
           $"\r\n\r\npublic class {className}: TR" +
           $"{{" +
           $"[DataMember, JsonProperty(\"{singleName}\")]" +
           $"public Single{className}? SingleResponse" +
           $"{{ get; set; }}" +
           $"[DataMember, JsonProperty(\"{multiName}\")]" +
           $"public Multi{multiName}[]? MultiResponse" +
           $"{{ get; set; }}" +
           $"}}";
}
foreach (var file in Directory.GetFiles(path, "*.enc", SearchOption.TopDirectoryOnly))
{
    var fi = new FileInfo(file);

    if (fi.Exists)
    {
        var code = Path.GetFileNameWithoutExtension(fi.Name);

        using var fileStream = File.OpenRead(Path.Combine(path, string.Concat(code, ".enc")));

        using var zip = new ZipArchive(fileStream, ZipArchiveMode.Read);

        foreach (var entry in zip.Entries)
        {
            var filePath = $"{createPath}\\{code}.cs";

            var buffer = new byte[0x4000];

            using var stream = entry.Open();

            stream.Read(buffer, 0, buffer.Length);

            var text = Encoding.GetEncoding(949).GetString(buffer);

            int nPos = 0, nPosEnd = 0;

            nPos = text.IndexOf("[INPUT]", nPos);
            nPos = text.IndexOf("@START_", nPos);
            nPos += "@START_".Length;
            nPosEnd = text.IndexOf("\r\n", nPos);

            var trName = text[nPos..nPosEnd];

            nPos = nPosEnd + "\r\n".Length;
            nPosEnd = text.IndexOf("@END_", nPos);

            var trInput = GetKeyNames(text[nPos..nPosEnd]);

            nPos = nPosEnd;
            nPos = text.IndexOf("[OUTPUT]", nPos);
            nPos = text.IndexOf("@START_", nPos);
            nPosEnd = text.IndexOf('=', nPos);

            var singleName = text.Substring(nPos + 7, nPosEnd - nPos - 7);

            nPos = nPosEnd + 1;
            nPosEnd = text.IndexOf("\r\n", nPos);

            var classification = text[nPos..nPosEnd];

            nPos = nPosEnd + "\r\n".Length;
            nPosEnd = text.IndexOf("@END_", nPos);

            var contents = text[nPos..nPosEnd];

            string[] trMultiData = Array.Empty<string>();

            string? multiName = null;

            if (classification == "*,*,*")
            {
                var trSingleData = GetKeyNames(contents);

                for (int i = 0; i < trSingleData.Length; i++)
                {
                    Console.WriteLine(trSingleData[i]);
                }
                nPos = nPosEnd + "\r\n".Length;
                nPos = text.IndexOf("@START_", nPos);

                if (nPos != -1)
                {
                    nPosEnd = text.IndexOf('=', nPos);

                    multiName = text.Substring(nPos + 7, nPosEnd - nPos - 7);

                    nPosEnd = text.IndexOf("\r\n", nPos);
                    nPos = nPosEnd + "\r\n".Length;
                    nPosEnd = text.IndexOf("@END_", nPos);

                    trMultiData = GetKeyNames(text[nPos..nPosEnd]);
                }
            }
            else
            {
                trMultiData = GetKeyNames(contents);
            }
            for (int i = 0; i < trMultiData.Length; i++)
            {
                Console.WriteLine(trMultiData[i]);
            }
            if (!new FileInfo(filePath).Exists)
            {
                File.WriteAllText(filePath, CreateClass(code, singleName, multiName));
            }
        }
    }
}