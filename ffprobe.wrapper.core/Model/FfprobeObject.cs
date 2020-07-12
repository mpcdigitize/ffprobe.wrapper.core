using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class FfprobeObject : IFfprobeObject
    {
        public Stream[] Streams { get; set; }
        public Format Format { get; set; } = new Format();
    }
}

