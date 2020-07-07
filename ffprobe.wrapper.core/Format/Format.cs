using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Format
{
    public class Format : IFormat
    {

        public string FileName { get; set; }
        public string FormatName { get; set; }
        public string FormatLongName { get; set; }
        public string Bitrate { get; set; }


    }
}
