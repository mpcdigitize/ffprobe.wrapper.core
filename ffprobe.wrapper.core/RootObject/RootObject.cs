using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class RootObject
    {

        public Stream[] Streams { get; set; }
        public Format Format { get; set; }
    }
}
