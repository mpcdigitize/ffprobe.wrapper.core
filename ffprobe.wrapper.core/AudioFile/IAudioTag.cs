namespace ffprobe.wrapper.core.Tags
{
    public interface IAudioTag
    {
        string Album { get; set; }
        string AlbumArtist { get; set; }
        string Artist { get; set; }
        string ArtistSort { get; set; }
        string Comment { get; set; }
        string Date { get; set; }
        string Disc { get; set; }
        string Genre { get; set; }
        string Title { get; set; }
        string Track { get; set; }
    }
}