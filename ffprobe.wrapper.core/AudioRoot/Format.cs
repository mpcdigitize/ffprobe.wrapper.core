using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.AudioRoot
{
    public class Format
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("format_name")]
        public string FormatName { get; set; }

        [JsonProperty("format_long_name")]
        public string FormatLongName { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        //[JsonProperty("tag")]
        public Tags Tags { get; set; } 




    }
}
