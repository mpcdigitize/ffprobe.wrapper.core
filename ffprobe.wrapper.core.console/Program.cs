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

            string path = @"C:\ffmpeg\ffprobe.exe";

            //string localFile = @"C:\input\ABBA.mp3";
            //string localFile = @"C:\input\12 Give Me Love.m4a";
            //string localFile = @"C:\input\Bruce Springsteen - Tunnel of Love - 01 - Ain't Got You (Album Version).flac";
            //Gary Moore - Still Got the Blues - 01 - Moving On
            //string localFile = @"C:\input\Gary Moore - Still Got the Blues - 01 - Moving On.flac";
            //0a062e15d407c6040d4d75c43ee8b771
            string localFile = @"C:\input\0a062e15d407c6040d4d75c43ee8b771.mp3";
            var ffprobe = new Ffprobe(path);

           // string streamFile = @"http://stream.revma.ihrhls.com/zc4802/hls.m3u8"; //at40
            //string streamFile = @"http://media-sov.musicradio.com/LBCLondon?type=.flv&awsparams=kxsegs:||;&amsparams=playerid:UKRP;skey:1484626109;&kuid=LBH7UpJ-&amsparams%3Dplayerid%3AUKRP%3Bskey%3A1484712106&listenerid=6c8483299a871c0dba4b6177f4ad49a3&awparams=companionAds%3Atrue&rpempv=3.1.101;"; //lbc
            //string streamFile = @"http://stream.revma.ihrhls.com/zc4802/hls.m3u8"; //at40
            //string streamFile = @"http://stream.revma.ihrhls.com/zc4802/hls.m3u8"; //at40
            //string streamFile = @"http://stream.revma.ihrhls.com/zc4802/hls.m3u8"; //at40

            var audio = ffprobe.GetAudioFileInfo(localFile);
            ffprobe.ReadInput(localFile);

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("File Name: " + audio.Format.FileName);
            Console.WriteLine("Format Name: " + audio.Format.FormatName);
            Console.WriteLine("Format Long Name: " + audio.Format.FormatLongName);
            Console.WriteLine("Duration: " + audio.Format.Duration);
            Console.WriteLine("Size: " + audio.Format.Size);

            
            Console.WriteLine("Artist: " + audio.Format.Tags.Artist);
            Console.WriteLine("Album: " + audio.Format.Tags.Album);
            Console.WriteLine("Title: " + audio.Format.Tags.Title);
            Console.WriteLine("Date: " + audio.Format.Tags.Date);
            Console.WriteLine("AlbumArtist: " + audio.Format.Tags.AlbumArtist);
            Console.WriteLine("ArtistSort: " + audio.Format.Tags.ArtistSort);
            Console.WriteLine("Comment: " + audio.Format.Tags.Comment);
            Console.WriteLine("Disc: " + audio.Format.Tags.Disc);
            Console.WriteLine("Genre: " + audio.Format.Tags.Genre);
            Console.WriteLine("Track: " + audio.Format.Tags.Track);

            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < audio.Streams.Length; i++)
            {
                Console.WriteLine("Index: " + audio.Streams[i].Index);
                Console.WriteLine("Codec Name: " + audio.Streams[i].CodecName);
                Console.WriteLine("Codec Long Name: " + audio.Streams[i].CodecLongName);
                Console.WriteLine("Codec Type: " + audio.Streams[i].CodecType);
                Console.WriteLine("Bitrate: " + audio.Streams[i].Bitrate);
                Console.WriteLine("Channels: " + audio.Streams[i].Channels);
                Console.WriteLine("Channel Layout: " + audio.Streams[i].ChannelsLayout);
                Console.WriteLine("Duration: " + audio.Streams[i].Duration);
                Console.WriteLine("Sample Rate: " + audio.Streams[i].SampleRate);

                Console.WriteLine("--------------------------------------------------");
            }



            Console.WriteLine("--------------------END----------------------");


            //ffprobe.ReadInput(streamFile);





        }
    }
}
