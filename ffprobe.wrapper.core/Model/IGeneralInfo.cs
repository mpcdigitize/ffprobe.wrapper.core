using System.Collections.Generic;

namespace ffprobe.wrapper.core.Model
{
    public interface IGeneralInfo
    {
        string Bitrate { get; set; }
        string Duration { get; set; }
        string FileName { get; set; }
        string FormatLongName { get; set; }
        string FormatName { get; set; }
        int NumberOfStreams { get; set; }
        string Size { get; set; }
        IEnumerable<IStreamInfo> Streams { get; set; }
    }
}