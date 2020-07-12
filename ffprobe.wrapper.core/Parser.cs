using ffprobe.wrapper.core.Enums;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ffprobe.wrapper.core
{
    public class Parser : IParser
    {
        private readonly IFileReader _reader;


        public Parser(IFileReader reader)
        {
            _reader = reader;

        }


        public IFfprobeObject GetMetadata(string filePath)
        {

            string stream = _reader.DoWork(filePath, OutputFormat.Json);

            IFfprobeObject metadata = JsonConvert.DeserializeObject<FfprobeObject>(stream);

            return metadata;

        }




    }
}
