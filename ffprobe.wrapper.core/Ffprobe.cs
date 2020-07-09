﻿using ffprobe.wrapper.core.AudioRoot;
using ffprobe.wrapper.core.Enums;
using ffprobe.wrapper.core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class Ffprobe
    {

        private readonly IReaderArguments _arguments;
        private IFileReader _reader;
        private readonly IParser _parser;

        public Ffprobe(string programPath)
        {
            _arguments = new ReaderArguments();
            _reader = new FileReader(_arguments,programPath);
            _parser = new Parser(_reader);
        }


        public AudioRootFile GetAudioFileInfo(string inputFile)
        {

           return _parser.GetAudioRootMetadata(inputFile);
        
        }


        public AudioStreamFile GetAudioStreamInfo(string inputFile)
        {

            return _parser.GetAudioStreamMetadata(inputFile);

        }


        public void ReadInput(string inputFile)
        {
            string stream = _reader.DoWork(inputFile, OutputFormat.Json);

            Console.WriteLine(stream);
        }



    }
}
