namespace ffprobe.wrapper.core
{
    public interface IFfprobe
    {
        IFfprobeObject GetMetadata(string inputFile);
        string ReadInput(string inputFile);
    }
}