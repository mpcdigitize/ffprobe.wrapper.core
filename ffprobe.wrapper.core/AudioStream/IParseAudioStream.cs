using ffprobe.wrapper.core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core.AudioStream
{
    public interface IParseAudioStream: IGeneralInfo, IAudioStreamTag
    {
    }
}
