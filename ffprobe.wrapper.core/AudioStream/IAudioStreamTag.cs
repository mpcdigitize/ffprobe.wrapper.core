namespace ffprobe.wrapper.core.AudioStream
{
    public interface IAudioStreamTag
    {
        string Bitrate { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        string StreamUrl { get; set; }
        string Url { get; set; }
    }
}