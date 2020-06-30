using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class StreamDetails
    {
        public int Index { get; set; }
        public string Codec { get; set; }
        public string CodecLongName { get; set; }
        public string CodecType { get; set; }
        public string SampleRate { get; set; }
        public int Channels { get; set; }
        public string ChannelLayout { get; set; }
        public string Bitrate { get; set; }

    }
}
