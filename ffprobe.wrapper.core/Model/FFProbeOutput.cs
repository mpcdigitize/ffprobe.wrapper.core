using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class FFProbeOutput
    {
        public int NumberOfStreams { get; set; }
        public string FormatName { get; set; }
        public string FormatLongName { get; set; }
        public Double DurationInSeconds { get; set; }
        public IEnumerable<StreamDetails> Streams { get; set; }

        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }

    }
}
