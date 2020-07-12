using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class Stream
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("bit_rate")]
        public string Bitrate { get; set; }

        [JsonProperty("channels")]
        public string Channels { get; set; }

        [JsonProperty("channel_layout")]
        public string ChannelsLayout { get; set; }

        [JsonProperty("codec_long_name")]
        public string CodecLongName { get; set; }

        [JsonProperty("codec_name")]
        public string CodecName { get; set; }

        [JsonProperty("codec_type")]
        public string CodecType { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("sample_rate")]
        public string SampleRate { get; set; }

    }
}


