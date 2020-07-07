using System;
using System.Collections.Generic;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class ReaderArguments : IReaderArguments
    {
        private Dictionary<string, string> _arguments;

        public ReaderArguments()
        {
            _arguments = new Dictionary<string, string>();


            _arguments.Add("Json", " -v error -print_format json -show_format -show_streams ");
            _arguments.Add("Xml", " -v quiet -print_format xml -show_format -show_streams ");



        }



        public string GetValue(string argument)
        {

            string value = "";

            _arguments.TryGetValue(argument, out value);

            return value;
        }


    }
}
