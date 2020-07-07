using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class StreamInfo : IStreamInfo
    {
        
        public int StreamIndex { get; set; }
        public string CodecName { get; set; }
        public string CodecLongName { get; set; }
        public string CodecType { get; set; }
        public string SampleRate { get; set; }
        public string Channels { get; set; }
        public string ChannelsLayout { get; set; }
        public string Duration { get; set; }
        public string Bitrate { get; set; }


    }
}
