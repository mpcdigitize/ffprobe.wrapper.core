using ffprobe.wrapper.core.Enums;

namespace ffprobe.wrapper.core
{
    public interface IFileReader
    {
        string DoWork(string inputFile, OutputFormat outputFormat);
    }
}