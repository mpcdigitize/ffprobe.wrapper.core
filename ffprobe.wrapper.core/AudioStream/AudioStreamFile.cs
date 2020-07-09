using ffprobe.wrapper.core.AudioStream;
using ffprobe.wrapper.core.Tags;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class AudioStreamFile : IParseAudioStream
    {
        public string Bitrate { get ; set ; }
        public string Duration { get; set; }
        public string FileName { get; set; }
        public string FormatLongName { get; set; }
        public string FormatName { get; set; }
        public int NumberOfStreams { get; set; }
        public string Size { get; set; }
        public IEnumerable<IStreamInfo> Streams { get; set; }
        
        [JsonProperty("icy-description")]
        public string Description { get; set; }
        public string Name { get; set; }
        public string StreamUrl { get; set; }
        public string Url { get; set; }
    }
}
