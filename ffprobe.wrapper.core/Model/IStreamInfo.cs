using System.Dynamic;

namespace ffprobe.wrapper.core.Model
{
    public interface IStreamInfo
    {

        int StreamIndex { get; set; }
        string Bitrate { get; set; }
        string Channels { get; set; }
        string ChannelsLayout { get; set; }
        string CodecLongName { get; set; }
        string CodecName { get; set; }
        string CodecType { get; set; }
        string Duration { get; set; }
        string SampleRate { get; set; }
    }
}