namespace ffprobe.wrapper.core
{
    public interface IFfprobeObject
    {
        Format Format { get; set; }
        Stream[] Streams { get; set; }
    }
}