using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class FileLogUpperStrategy : IStraregy
    {
        public void Log(string path, string textToLog)
        {
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(textToLog.ToUpper() + "\n");
                fstream.Seek(0, SeekOrigin.End);
                fstream.Write(input);
            }
        }
    }
}
