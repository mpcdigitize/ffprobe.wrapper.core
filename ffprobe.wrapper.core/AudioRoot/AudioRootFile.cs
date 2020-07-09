using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.AudioRoot
{
    public class AudioRootFile
    {
        public Stream[] Streams { get; set; }
        public Format Format { get; set; }
    }
}

