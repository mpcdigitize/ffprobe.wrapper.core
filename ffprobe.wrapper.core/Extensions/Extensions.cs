using ffprobe.wrapper.core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Extensions
{
    public static class Extensions
    {

        public static RootObject GetMetadata(this string readerOutput)
        {
            RootObject metadata = JsonConvert.DeserializeObject<RootObject>(readerOutput);

            return metadata;
        }

    }
}
