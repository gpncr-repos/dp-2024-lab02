using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    public class ConsoleLogStrategy : IStraregy
    {
        public void Log(string path, string textToLog)
        {
            Console.WriteLine(textToLog);
        }
    }
}
