using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Logger
    {
        public string path;
        public string textToLog;

        public Logger(string path, string textToLog, IStraregy strat)
        {
            this.path = path;
            this.textToLog = textToLog;
            Straregy = strat;
        }


        public IStraregy Straregy { private get; set; }

        public void Log()
        {
            Straregy.Log(path, textToLog);
        }
    }
}