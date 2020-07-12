using ffprobe.wrapper.core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class Ffprobe : IFfprobe
    {

        private readonly IReaderArguments _arguments;
        private IFileReader _reader;
        private readonly IParser _parser;

        public Ffprobe(string programPath)
        {
            _arguments = new ReaderArguments();
            _reader = new FileReader(_arguments, programPath);
            _parser = new Parser(_reader);
        }


        public IFfprobeObject GetMetadata(string inputFile)
        {

            return _parser.GetMetadata(inputFile);

        }


        public string ReadInput(string inputFile)
        {
            string stream = _reader.DoWork(inputFile, OutputFormat.Json);

            return stream;
        }



    }
}
