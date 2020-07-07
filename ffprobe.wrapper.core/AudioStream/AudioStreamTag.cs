using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.AudioStream
{
    public class AudioStreamTag : IAudioStreamTag
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Bitrate { get; set; }
        public string StreamUrl { get; set; }
        public string Description { get; set; }


    }
}
