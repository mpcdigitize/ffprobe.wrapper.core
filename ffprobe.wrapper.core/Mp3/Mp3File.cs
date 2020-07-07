using ffprobe.wrapper.core.Mp3;
using ffprobe.wrapper.core.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Model
{
    public class Mp3File : IParseMp3File
    {
        public string Bitrate { get ; set ; }
        public string Duration { get; set; }
        public string FileName { get; set; }
        public string FormatLongName { get; set; }
        public string FormatName { get; set; }
        public int NumberOfStreams { get; set; }
        public string Size { get; set; }
        public IEnumerable<IStreamInfo> Streams { get; set; }
        public string Album { get; set; }
        public string AlbumArtist { get; set; }
        public string Artist { get; set; }
        public string ArtistSort { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public string Disc { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Track { get; set; }
    }
}

