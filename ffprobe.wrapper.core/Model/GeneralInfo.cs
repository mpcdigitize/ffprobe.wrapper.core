using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class GeneralInfo : IGeneralInfo
    {


        public int NumberOfStreams { get; set; }
        public string FileName { get; set; }
        public string FormatName { get; set; }
        public string FormatLongName { get; set; }
        public string Duration { get; set; }
        public string Size { get; set; }
        public string Bitrate { get; set; }

        public IEnumerable<IStreamInfo> Streams { get; set; }


    }
}
