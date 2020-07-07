using ffprobe.wrapper.core.AudioStream;
using ffprobe.wrapper.core.Enums;
using ffprobe.wrapper.core.Model;
using ffprobe.wrapper.core.Mp3;
using System;

namespace ffprobe.wrapper.core.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //IParseAudioStream sr = new AudioStreamFile();
           // IParseMp3File mp3 = new Mp3File();

            string path = @"C:\ffmpeg\ffprobe.exe";

            /*
            var argmnts = new ReaderArguments();
            var freader = new FileReader(argmnts,path);
            var parser = new Parser(freader);
            */


            //string localFile = @"C:\input\ABBA.mp3";
            string localFile = @"C:\input\12 Give Me Love.m4a";
            var ffprobe = new Ffprobe(path);

            var mp3 = ffprobe.GetInfo(localFile);



            Console.WriteLine("No of Streams: " + mp3.NumberOfStreams);

            Console.WriteLine("Title: " + mp3.Title);
            Console.WriteLine("Artist: " + mp3.Artist);
            Console.WriteLine("Album: " + mp3.Album);
            Console.WriteLine("Bitrate: " + mp3.Bitrate);
            Console.WriteLine("Duration: " + mp3.Duration);
            Console.WriteLine("File Name: " + mp3.FileName);
            Console.WriteLine("Format Name: " + mp3.FormatName);
            Console.WriteLine("Format Long Name: " + mp3.FormatLongName);
            Console.WriteLine("Size: " + mp3.Size);

            Console.WriteLine("---------------------------------------");

            foreach (var item in mp3.Streams)
            {
                Console.WriteLine("Index: " + item.StreamIndex);
                Console.WriteLine("CodecName: " + item.CodecName);
                Console.WriteLine("CodecLongName: " + item.CodecLongName);
                Console.WriteLine("Bitrate: " + item.Bitrate);
                Console.WriteLine("Channels: " + item.Channels);
                Console.WriteLine("Layout: " + item.ChannelsLayout);
                Console.WriteLine("Type: " + item.CodecType);
                Console.WriteLine("Duration: " + item.Duration);
                Console.WriteLine("SampleRate: " + item.SampleRate);
                Console.WriteLine("---------------------------------------");

            }


            Console.WriteLine("-----------END-------------");

            //parser.ReadInput(localFile,OutputFormat.Json);

            /*
            var reader = new MetadataReader(@"C:\ffmpeg\ffprobe.exe");
            //string localFile = @"C:\input\ABBA.mp3";
            //string localFile = @"C:\input\00e3a0b59da1888666ac44f1eebe6e46.mp3";
            string localFile = @"C:\input\12 Give Me Love.m4a";
            //string localFile = @"C:\input\01 Faded.m4a";
            //string localFile = @"C:\input\testWTV.wtv";
            //string localFile = @"http://stream3.polskieradio.pl:8904/;stream";
           // string localFile = @"http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_q";

            var json = reader.DoWork(localFile, OutputFormat.Json);

            reader.ParseJson(json);

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

            */

        }
    }
}
