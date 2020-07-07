using ffprobe.wrapper.core.AudioStream;
using ffprobe.wrapper.core.Enums;
using ffprobe.wrapper.core.Extensions;
using ffprobe.wrapper.core.Model;
using ffprobe.wrapper.core.Mp3;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class Parser : IParser
    {
        private readonly IFileReader _reader;


        public Parser(IFileReader reader)
        {
            _reader = reader;

        }

        public void ReadInput(string inputFile, OutputFormat outputFormat)
        {
            string stream = _reader.DoWork(inputFile, outputFormat);

            Console.WriteLine(stream);
        }

        public AudioFile GetMp3Metadata(string filePath)
        {
            AudioFile mp3 = new AudioFile();
            string stream = _reader.DoWork(filePath, OutputFormat.Json);
            var deserializedStream = stream.DeserializeOutput();
            StreamInfo streamInfo;
            List<StreamInfo> Streams = new  List<StreamInfo>();

            mp3.NumberOfStreams = deserializedStream.format.nb_streams;
            mp3.Album = deserializedStream.format.tags.album;
            mp3.Artist = deserializedStream.format.tags.artist;
            mp3.AlbumArtist = deserializedStream.format.tags.album_artist;
            mp3.ArtistSort = deserializedStream.format.tags.artist_sort;
            mp3.Bitrate = deserializedStream.format.bit_rate;
            mp3.Comment = deserializedStream.format.tags.comment;
            mp3.Date = deserializedStream.format.tags.date;
            mp3.Disc = deserializedStream.format.tags.disc;
            mp3.Duration = deserializedStream.format.duration;
            mp3.FileName = deserializedStream.format.filename;
            mp3.FormatLongName = deserializedStream.format.format_long_name;
            mp3.FormatName = deserializedStream.format.format_name;
            mp3.Genre = deserializedStream.format.tags.genre;
            mp3.Size = deserializedStream.format.size;
            mp3.Title = deserializedStream.format.tags.title;
            mp3.Track = deserializedStream.format.tags.track;

            for (int i = 0; i < mp3.NumberOfStreams ; i++)
            {
                streamInfo = new StreamInfo();

                streamInfo.StreamIndex = deserializedStream.streams[i].index;
                streamInfo.Bitrate = deserializedStream.streams[i].bit_rate;
                streamInfo.Channels = deserializedStream.streams[i].channels;
                streamInfo.ChannelsLayout = deserializedStream.streams[i].channel_layout;
                streamInfo.CodecLongName = deserializedStream.streams[i].codec_long_name;
                streamInfo.CodecName = deserializedStream.streams[i].codec_name;
                streamInfo.CodecType = deserializedStream.streams[i].codec_type;
                streamInfo.Duration = deserializedStream.streams[i].duration;
                streamInfo.SampleRate = deserializedStream.streams[i].sample_rate;



                Streams.Add(streamInfo);

            }

            mp3.Streams = Streams;

            return mp3;

        }


        public AudioStreamFile GetAudioStreamMetadata(string filePath)
        {
            AudioStreamFile audioStream = new AudioStreamFile();
            string stream = _reader.DoWork(filePath, OutputFormat.Json);
            var deserializedStream = stream.DeserializeOutput();
            StreamInfo streamInfo;
            List<StreamInfo> Streams = new List<StreamInfo>();


            audioStream.NumberOfStreams = 0;

            audioStream.Bitrate = deserializedStream.format.bit_rate; ;
            audioStream.Description = deserializedStream.format.tags.icy_description;
            audioStream.Duration = deserializedStream.format.duration; ;
            audioStream.FileName = deserializedStream.format.filename; ;
            audioStream.FormatLongName = deserializedStream.format.format_long_name; ;
            audioStream.FormatName = deserializedStream.format.format_name; ;
            audioStream.Name = deserializedStream.format.tags.icy_name;
            audioStream.Size = deserializedStream.format.size; ;
            audioStream.StreamUrl = deserializedStream.format.tags.StreamUrl;
            audioStream.Url = deserializedStream.format.tags.icy_url;


            for (int i = 0; i < audioStream.NumberOfStreams; i++)
            {
                streamInfo = new StreamInfo();

                streamInfo.StreamIndex = deserializedStream.streams[i].index;
                streamInfo.Bitrate = deserializedStream.streams[i].bit_rate;
                streamInfo.Channels = deserializedStream.streams[i].channels;
                streamInfo.ChannelsLayout = deserializedStream.streams[i].channel_layout;
                streamInfo.CodecLongName = deserializedStream.streams[i].codec_long_name;
                streamInfo.CodecName = deserializedStream.streams[i].codec_name;
                streamInfo.CodecType = deserializedStream.streams[i].codec_type;
                streamInfo.Duration = deserializedStream.streams[i].duration;
                streamInfo.SampleRate = deserializedStream.streams[i].sample_rate;



                Streams.Add(streamInfo);

            }


            audioStream.Streams = Streams;

            return audioStream;

        }


    }
}
