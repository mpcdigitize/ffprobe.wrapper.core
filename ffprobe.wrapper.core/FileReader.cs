using ffprobe.wrapper.core.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ffprobe.wrapper.core
{
    public class FileReader : IFileReader
    {
        private readonly IReaderArguments _args;
        private readonly string _programPath;

        public FileReader(IReaderArguments args, string programPath)
        {
            _args = args;
            _programPath = programPath;
        }

        public string DoWork(string inputFile, OutputFormat outputFormat)
        {


            Process process = new Process();
            string readerOutput = "";



            process.StartInfo.Arguments = _args.GetValue(outputFormat.ToString()) + "\"" + inputFile + "\"";
            process.StartInfo.FileName = _programPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;


            process.Start();

            using (StreamReader reader = process.StandardOutput)
            {

                readerOutput = reader.ReadToEnd();

            }


            process.WaitForExit();

            return readerOutput;

        }



    }
}
