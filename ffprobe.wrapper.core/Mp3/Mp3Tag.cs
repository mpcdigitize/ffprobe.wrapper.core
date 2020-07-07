using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.Tags
{
    public class Mp3Tag : IMp3Tag
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        public string AlbumArtist { get; set; }
        public string Disc { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Track { get; set; }
        public string ArtistSort { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }



    }
}
