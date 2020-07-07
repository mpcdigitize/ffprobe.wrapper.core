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

        public AudioFile GetAudioMetadata(string filePath)
        {
            AudioFile audioFile = new AudioFile();
            string stream = _reader.DoWork(filePath, OutputFormat.Json);
            var deserializedStream = stream.DeserializeOutput();
            StreamInfo streamInfo;
            List<StreamInfo> Streams = new  List<StreamInfo>();

            audioFile.NumberOfStreams = deserializedStream.format.nb_streams;
            audioFile.Album = deserializedStream.format.tags.album;

            if (audioFile.Album == null)
            {

                audioFile.Album = deserializedStream.format.tags.ALBUM;

            }

            audioFile.Artist = deserializedStream.format.tags.artist;

            if (audioFile.Artist == null)
            {

                audioFile.Artist = deserializedStream.format.tags.ARTIST;

            }

            audioFile.Title = deserializedStream.format.tags.title;

            if (audioFile.Title == null)
            {

                audioFile.Title = deserializedStream.format.tags.TITLE;

            }

            audioFile.AlbumArtist = deserializedStream.format.tags.album_artist;

            if (audioFile.AlbumArtist == null)
            {

                audioFile.AlbumArtist = deserializedStream.format.tags.ALBUM_ARTIST;

            }


            audioFile.ArtistSort = deserializedStream.format.tags.artist_sort;

            if (audioFile.ArtistSort == null)
            {

                audioFile.ArtistSort = deserializedStream.format.tags.ARTIST_SORT;

            }

            audioFile.Comment = deserializedStream.format.tags.comment;

            if (audioFile.Comment == null)
            {

                audioFile.Comment = deserializedStream.format.tags.COMMENT;

            }


            audioFile.Date = deserializedStream.format.tags.date;

            if (audioFile.Date == null)
            {

                audioFile.Date = deserializedStream.format.tags.DATE;

            }


            audioFile.Disc = deserializedStream.format.tags.disc;

            if (audioFile.Disc == null)
            {

                audioFile.Disc = deserializedStream.format.tags.DISC;

            }

            audioFile.Genre = deserializedStream.format.tags.genre;

            if (audioFile.Genre == null)
            {

                audioFile.Genre = deserializedStream.format.tags.GENRE;

            }

            audioFile.Track = deserializedStream.format.tags.track;

            if (audioFile.Track == null)
            {

                audioFile.Track = deserializedStream.format.tags.TRACK;

            }



            audioFile.Bitrate = deserializedStream.format.bit_rate;

            if (audioFile.Bitrate == null)
            {

                audioFile.Bitrate = deserializedStream.format.bits_per_raw_sample;

            }

            audioFile.Duration = deserializedStream.format.duration;
            audioFile.FileName = deserializedStream.format.filename;
            audioFile.FormatLongName = deserializedStream.format.format_long_name;
            audioFile.FormatName = deserializedStream.format.format_name;         
            audioFile.Size = deserializedStream.format.size;
            
            

            for (int i = 0; i < audioFile.NumberOfStreams ; i++)
            {
                streamInfo = new StreamInfo();

                streamInfo.StreamIndex = deserializedStream.streams[i].index;
                streamInfo.Bitrate = deserializedStream.streams[i].bit_rate;

                if (streamInfo.Bitrate == null)
                {

                    streamInfo.Bitrate = deserializedStream.streams[i].bits_per_raw_sample;

                }

                streamInfo.Channels = deserializedStream.streams[i].channels;
                streamInfo.ChannelsLayout = deserializedStream.streams[i].channel_layout;
                streamInfo.CodecLongName = deserializedStream.streams[i].codec_long_name;
                streamInfo.CodecName = deserializedStream.streams[i].codec_name;
                streamInfo.CodecType = deserializedStream.streams[i].codec_type;
                streamInfo.Duration = deserializedStream.streams[i].duration;
                streamInfo.SampleRate = deserializedStream.streams[i].sample_rate;



                Streams.Add(streamInfo);

            }

            audioFile.Streams = Streams;

            return audioFile;

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
