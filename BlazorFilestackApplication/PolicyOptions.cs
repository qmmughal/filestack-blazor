using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFilestackApplication
{
    public static class CallOptions
    {
        public const string Pick = "pick";
        public const string Read = "read";
        public const string Stat = "stat";
        public const string Write = "write";
        public const string WriteUrl = "writeUrl";
        public const string Store = "store";
        public const string Convert = "convert";
        public const string Remove = "remove";
        public const string Exif = "exif";
        public const string RunWorkflow = "runWorkflow";
    }

    public class PolicyOptions
    {
        public List<string> Call;
        public int Expiry;
        public string Handle;
        public string Url;
        public string Path;
        public string Container;
        public int MinSize;
        public int MaxSize;
    }
}
