namespace ffprobe.wrapper.core.Format
{
    public interface IFormat
    {
        string Bitrate { get; set; }
        string FileName { get; set; }
        string FormatLongName { get; set; }
        string FormatName { get; set; }
    }
}