using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.FFmpeg.Downloader.Networking;

public static class UrlParser
{
    public static readonly UrlParser Instance = Instance ??= new();
    public readonly Uri? FFmpeg, FFprobe, FFPlay;
    public readonly string Version;

    private UrlParser()
    {
        JObject json = GetJ.son();
    }
}
