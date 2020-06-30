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



        public FFProbeOutput ReadStream(string inputFile)
        {

            var ffProbeOutput = new FFProbeOutput();
            string output = "";
            List<StreamDetails> streams = new List<StreamDetails>();

            output = DoWork(inputFile, OutputFormat.Json);

            ffProbeOutput.NumberOfStreams = output.GetMetadata().format.nb_streams;
            ffProbeOutput.FormatName = output.GetMetadata().format.format_name;
            ffProbeOutput.FormatLongName = output.GetMetadata().format.format_long_name;
            ffProbeOutput.DurationInSeconds = Convert.ToDouble(output.GetMetadata().format.duration);
            ffProbeOutput.Album = output.GetMetadata().format.tags.album;
            ffProbeOutput.Artist = output.GetMetadata().format.tags.artist;
            ffProbeOutput.Title = output.GetMetadata().format.tags.title;


            for (int i = 0; i < ffProbeOutput.NumberOfStreams; i++)
            {

                var stream = new StreamDetails();

                stream.Bitrate = output.GetMetadata().streams[i].bit_rate;
                stream.ChannelLayout = output.GetMetadata().streams[i].channel_layout;
                stream.Channels = output.GetMetadata().streams[i].channels;
                stream.Codec = output.GetMetadata().streams[i].codec_name;
                stream.CodecLongName = output.GetMetadata().streams[i].codec_long_name;
                stream.CodecType = output.GetMetadata().streams[i].codec_type;
                stream.Index = output.GetMetadata().streams[i].index;
                stream.SampleRate = output.GetMetadata().streams[i].sample_rate;




                streams.Add(stream);





            }

            ffProbeOutput.Streams = streams;

            return ffProbeOutput;



        }
    }
}
