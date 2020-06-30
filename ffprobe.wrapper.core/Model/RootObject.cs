using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class RootObject
    {

        public Stream[] streams { get; set; }
        public Format format { get; set; }
    }
}
