using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    public class FileLogStrategy : IStraregy
    {
        public void Log(string path, string textToLog)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(textToLog + "\n");
                fstream.Seek(0, SeekOrigin.End);
                fstream.Write(input);
            }
        }
    }
}
