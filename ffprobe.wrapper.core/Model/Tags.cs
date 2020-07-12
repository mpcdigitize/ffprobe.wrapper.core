using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class Tags
    {
        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("album_artist")]
        public string AlbumArtist { get; set; }

        [JsonProperty("disc")]
        public string Disc { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("track")]
        public string Track { get; set; }

        [JsonProperty("artist_sort")]
        public string ArtistSort { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("icy-name")]
        public string IcyName { get; set; }

        [JsonProperty("icy-url")]
        public string IcyUrl { get; set; }

        [JsonProperty("icy-br")]
        public string IcyBitrate { get; set; }

        [JsonProperty("StreamUrl")]
        public string IcyStreamUrl { get; set; }

        [JsonProperty("icy-description")]
        public string IcyDescription { get; set; }

        [JsonProperty("icy-genre")]
        public string IcyGenre { get; set; }

        [JsonProperty("StreamTitle")]
        public string IcyStreamTitle { get; set; }

        [JsonProperty("WM/SubTitle")]
        public string WtvEpisodeTitle { get; set; }

        [JsonProperty("WM/SubTitleDescription")]
        public string WtvEpisodeDescription { get; set; }
    }
}
