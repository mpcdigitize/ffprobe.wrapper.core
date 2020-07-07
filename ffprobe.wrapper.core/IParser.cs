using ffprobe.wrapper.core.Enums;
using ffprobe.wrapper.core.Model;

namespace ffprobe.wrapper.core
{
    public interface IParser
    {
        AudioStreamFile GetAudioStreamMetadata(string filePath);
        AudioFile GetMp3Metadata(string filePath);
        void ReadInput(string inputFile, OutputFormat outputFormat);
    }
}