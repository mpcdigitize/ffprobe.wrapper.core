using ffprobe.wrapper.core.Enums;

namespace ffprobe.wrapper.core
{
    public interface IParser
    {
        IFfprobeObject GetMetadata(string filePath);
    }
}