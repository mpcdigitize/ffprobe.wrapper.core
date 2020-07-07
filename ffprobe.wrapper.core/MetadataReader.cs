using ffprobe.wrapper.core.Enums;
using ffprobe.wrapper.core.Extensions;
using ffprobe.wrapper.core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class MetadataReader
    {
        private string _programmPath;
        private ReaderArguments _arguments;

        public MetadataReader(string programmPath)
        {
            _programmPath = programmPath;
            _arguments = new ReaderArguments();
        }

        public string DoWork(string inputFile, OutputFormat outputFormat)
        {


            Process process = new Process();
            string readerOutput = "";



            process.StartInfo.Arguments = _arguments.GetValue(outputFormat.ToString()) + "\"" + inputFile + "\"";
            process.StartInfo.FileName = _programmPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;


            process.Start();

            using (StreamReader reader = process.StandardOutput)
            {

                readerOutput = reader.ReadToEnd();

            }


            process.WaitForExit();

            return readerOutput;

        }



        public void ParseJson(string input)
        {

            var parsed = input.DeserializeOutput();

            Console.WriteLine("PARSED: " + parsed.format.nb_streams);
            Console.WriteLine("PARSED: " + parsed.format.tags.album);
            Console.WriteLine("PARSED: " + parsed.format.tags.artist);
            Console.WriteLine("PARSED: " + parsed.format.tags.title);
            Console.WriteLine("PARSED: " + parsed.streams[0].bit_rate);
            Console.WriteLine("PARSED: " + parsed.streams[1].codec_long_name);

        }


        public FFProbeOutput ReadStream(string inputFile)
        {

            var ffProbeOutput = new FFProbeOutput();
            string output = "";
            List<StreamDetails> streams = new List<StreamDetails>();

            output = DoWork(inputFile, OutputFormat.Json);

            ffProbeOutput.NumberOfStreams = output.GetMetadata().Format.nb_streams;
            ffProbeOutput.FormatName = output.GetMetadata().Format.format_name;
            ffProbeOutput.FormatLongName = output.GetMetadata().Format.format_long_name;
            ffProbeOutput.DurationInSeconds = Convert.ToDouble(output.GetMetadata().Format.duration);
          //  ffProbeOutput.Album = output.GetMetadata().Format.tags.album;
          //  ffProbeOutput.Artist = output.GetMetadata().Format.tags.artist;
          //  ffProbeOutput.Title = output.GetMetadata().Format.tags.title;


            for (int i = 0; i < ffProbeOutput.NumberOfStreams; i++)
            {

                var stream = new StreamDetails();

                stream.Bitrate = output.GetMetadata().Streams[i].bit_rate;
                stream.ChannelLayout = output.GetMetadata().Streams[i].channel_layout;
                stream.Channels = output.GetMetadata().Streams[i].channels;
                stream.Codec = output.GetMetadata().Streams[i].codec_name;
                stream.CodecLongName = output.GetMetadata().Streams[i].codec_long_name;
                stream.CodecType = output.GetMetadata().Streams[i].codec_type;
                stream.Index = output.GetMetadata().Streams[i].index;
                stream.SampleRate = output.GetMetadata().Streams[i].sample_rate;




                streams.Add(stream);





            }

            ffProbeOutput.Streams = streams;

            return ffProbeOutput;



        }
    }
}
