﻿using ShareInvest.Utilities.Naver;

using System.Globalization;
using System.IO.Compression;
using System.Text;

namespace ShareInvest;

class Install
{
    internal async Task RunAsync()
    {
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
                    StringBuilder createContents = new(Syntax.CreateNamespace());

                    var filePath = string.Concat(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\", createPath)), '\\', code, ".cs");

                    if (new FileInfo(filePath).Exists)
                    {
                        continue;
                    }
                    string className = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(code);

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

                    var trInput = Syntax.GetKeyNames(text[nPos..nPosEnd]);

                    nPos = nPosEnd;
                    nPos = text.IndexOf("[OUTPUT]", nPos);
                    nPos = text.IndexOf("@START_", nPos);
                    nPosEnd = text.IndexOf('=', nPos);

                    createContents.Append(Syntax.CreateClass(className, trName));

                    var singleName = text.Substring(nPos + 7, nPosEnd - nPos - 7);

                    nPos = nPosEnd + 1;
                    nPosEnd = text.IndexOf("\r\n", nPos);

                    var classification = text[nPos..nPosEnd];

                    nPos = nPosEnd + "\r\n".Length;
                    nPosEnd = text.IndexOf("@END_", nPos);

                    var contents = text[nPos..nPosEnd];

                    string[] trMultiData = Array.Empty<string>(), trSingleData = Array.Empty<string>();

                    string? multiName = null;

                    StringBuilder? singleClass = null, multiClass = null;

                    if (classification == "*,*,*")
                    {
                        createContents.Append(Syntax.CreateSingleResponse(className, singleName));

                        trSingleData = Syntax.GetKeyNames(contents);

                        singleClass = new StringBuilder(Syntax.CreateNamespace());

                        singleClass.Append(Syntax.CreateSingleResponseClass(className, singleName));

                        nPos = nPosEnd + "\r\n".Length;
                        nPos = text.IndexOf("@START_", nPos);

                        if (nPos != -1)
                        {
                            nPosEnd = text.IndexOf('=', nPos);

                            multiName = text.Substring(nPos + 7, nPosEnd - nPos - 7);

                            createContents.Append(Syntax.CreateMultiResponse(className, multiName));

                            nPosEnd = text.IndexOf("\r\n", nPos);
                            nPos = nPosEnd + "\r\n".Length;
                            nPosEnd = text.IndexOf("@END_", nPos);

                            trMultiData = Syntax.GetKeyNames(text[nPos..nPosEnd]);

                            multiClass = new StringBuilder(Syntax.CreateNamespace());

                            multiClass.Append(Syntax.CreateMultiResponseClass(className, multiName));
                        }
                    }
                    else
                    {
                        createContents.Append(Syntax.CreateMultiResponse(className, singleName));

                        trMultiData = Syntax.GetKeyNames(contents);

                        multiClass = new StringBuilder(Syntax.CreateNamespace());

                        multiClass.Append(Syntax.CreateMultiResponseClass(className, singleName));
                    }
                    for (int i = 0; i < trSingleData.Length; i++)
                    {
                        singleClass?.Append(Syntax.CreateProperty(trSingleData[i], await TranslateAsync(trSingleData[i])));
                    }
                    for (int i = 0; i < trMultiData.Length; i++)
                    {
                        multiClass?.Append(Syntax.CreateProperty(trMultiData[i], await TranslateAsync(trMultiData[i])));
                    }
                    createContents.Append(Syntax.CreateProperty(trInput, trName, className, trSingleData, trMultiData));

                    File.WriteAllText(filePath, createContents.Append('}').ToString());

                    if (singleClass != null)
                    {
                        File.WriteAllText(filePath.Replace("Entities", "Singles"), singleClass.Append('}').ToString());
                    }
                    if (multiClass != null)
                    {
                        File.WriteAllText(filePath.Replace("Entities", "Multiples"), multiClass.Append('}').ToString());
                    }
                }
            }
        }
    }
    internal Install(Papago papago, string path, string createPath)
    {
        this.path = path;
        this.createPath = createPath;
        this.papago = papago;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }
    async Task<string> TranslateAsync(string name)
    {
        if (tranlatedName.TryGetValue(name, out string? translatedName))
        {
            return translatedName;
        }
        var detectLangCode = await papago.DetectLanguage(name);

        if ("ko".Equals(detectLangCode))
        {
            var translatedText = Transform.TransformInbound((await papago.TranslateAsync(detectLangCode, name)).Value.Result.TranslatedText);

            if (tranlatedName.TryAdd(name, translatedText))
            {
                return translatedText;
            }
        }
        return name;
    }
    readonly string path;
    readonly string createPath;
    readonly Dictionary<string, string> tranlatedName = new()
    {
        { "종목코드", "Code" },
        { "종목명", "Name" }
    };
    readonly Papago papago;
}