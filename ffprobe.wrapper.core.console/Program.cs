using ffprobe.wrapper.core.Enums;
using System;

namespace ffprobe.wrapper.core.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var reader = new MetadataReader(@"C:\ffmpeg\ffprobe.exe");
            string localFile = @"C:\input\ABBA.mp3";
            string streamPR3 = @"http://stream3.polskieradio.pl:8904/;stream";

            var json = reader.DoWork(localFile, OutputFormat.Json);
            var output = reader.ReadStream(localFile);


            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(json);



            Console.WriteLine(output.NumberOfStreams);
            Console.WriteLine(output.FormatName);
            Console.WriteLine(output.DurationInSeconds);

            Console.WriteLine(output.Album);
            Console.WriteLine(output.Artist);
            Console.WriteLine(output.Title);



            foreach (var item in output.Streams)
            {
                Console.WriteLine(item.Index);
                Console.WriteLine(item.Codec);
                Console.WriteLine(item.CodecLongName);
                Console.WriteLine(item.CodecType);
                Console.WriteLine(item.Bitrate);


            }

        }
    }
}
