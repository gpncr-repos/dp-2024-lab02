using ConsoleApp4;
using System;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb = sb.Append(@"C:\Файлообмен\").Append("DP.P1.").Append(now.ToString("yyyy-MM-dd.HH-mm-ss")).Append(".log");

            string path = sb.ToString();

            Console.WriteLine("Выберите что-то одно:");
            Console.WriteLine("1. Вывод лога в консоль");
            Console.WriteLine("2. Вывод лога в файл");
            Console.WriteLine("3. ВЫВОД ЛОГА В ФАЙЛ БОЛЬШИМИ БУКВАМИ");
            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    ConsoleLogStrategy consoleLogStrategy = new ConsoleLogStrategy();

                    for (int i = 1; i < 21; i++)
                    {
                        string mesLevel = "";
                        string mesDesc = "";
                        Random rnd = new Random();
                        int randomNum = rnd.Next(0, 5);
                        if (randomNum == 0) { mesLevel = "TRACE"; mesDesc = "Детальная информация"; }
                        if (randomNum == 1) { mesLevel = "INFO"; mesDesc = "Программа работает нормально"; }
                        if (randomNum == 2) { mesLevel = "WARN"; mesDesc = "Предупреждение!"; }
                        if (randomNum == 3) { mesLevel = "ERROR"; mesDesc = "Ошибка!!"; }
                        if (randomNum == 4) { mesLevel = "FATAL"; mesDesc = "Разрушительная ошибка!!!"; }
                        DateTime now1 = DateTime.Now;
                        StringBuilder message = new StringBuilder();
                        message = message.Append(now1.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + mesLevel + "] ").Append(mesDesc);
                        string messageToLog = message.ToString();
                        Logger logger = new Logger("", messageToLog, consoleLogStrategy);
                        logger.Log();
                        //consoleLogStrategy.Log("", messageToLog);
                    }
                    break;
                case 2:
                    FileLogStrategy fileLogStrategy = new FileLogStrategy();
                    DateTime now2 = DateTime.Now;
                    StringBuilder sb2 = new StringBuilder();

                    sb2 = sb2.Append(@"C:\Файлообмен\").Append("DP.P1.").Append(now.ToString("yyyy-MM-dd.HH-mm-ss")).Append(".log");
                    string path2 = sb2.ToString();

                    for (int i = 1; i < 21; i++)
                    {
                        string mesLevel = "";
                        string mesDesc = "";
                        Random rnd = new Random();
                        int randomNum = rnd.Next(0, 5);
                        if (randomNum == 0) { mesLevel = "TRACE"; mesDesc = "Детальная информация"; }
                        if (randomNum == 1) { mesLevel = "INFO"; mesDesc = "Программа работает нормально"; }
                        if (randomNum == 2) { mesLevel = "WARN"; mesDesc = "Предупреждение!"; }
                        if (randomNum == 3) { mesLevel = "ERROR"; mesDesc = "Ошибка!!"; }
                        if (randomNum == 4) { mesLevel = "FATAL"; mesDesc = "Разрушительная ошибка!!!"; }
                        DateTime now1 = DateTime.Now;
                        StringBuilder message = new StringBuilder();
                        message = message.Append(now1.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + mesLevel + "] ").Append(mesDesc);
                        string messageToLog = message.ToString();
                        Logger logger = new Logger(path2, messageToLog, fileLogStrategy);
                        logger.Log();
                        //consoleLogStrategy.Log("", messageToLog);

                    }
                    break;
                case 3:
                    FileLogUpperStrategy fileLogUpperStrategy = new FileLogUpperStrategy();
                    DateTime now3 = DateTime.Now;
                    StringBuilder sb3 = new StringBuilder();

                    sb3 = sb3.Append(@"C:\Файлообмен\").Append("DP.P1.").Append(now.ToString("yyyy-MM-dd.HH-mm-ss")).Append(".log");
                    string path3 = sb3.ToString();

                    for (int i = 1; i < 21; i++)
                    {
                        string mesLevel = "";
                        string mesDesc = "";
                        Random rnd = new Random();
                        int randomNum = rnd.Next(0, 5);
                        if (randomNum == 0) { mesLevel = "TRACE"; mesDesc = "Детальная информация"; }
                        if (randomNum == 1) { mesLevel = "INFO"; mesDesc = "Программа работает нормально"; }
                        if (randomNum == 2) { mesLevel = "WARN"; mesDesc = "Предупреждение!"; }
                        if (randomNum == 3) { mesLevel = "ERROR"; mesDesc = "Ошибка!!"; }
                        if (randomNum == 4) { mesLevel = "FATAL"; mesDesc = "Разрушительная ошибка!!!"; }
                        DateTime now1 = DateTime.Now;
                        StringBuilder message = new StringBuilder();
                        message = message.Append(now1.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + mesLevel + "] ").Append(mesDesc);
                        string messageToLog = message.ToString();
                        Logger logger = new Logger(path3, messageToLog, fileLogUpperStrategy);
                        logger.Log();
                        //consoleLogStrategy.Log("", messageToLog);

                    }
                    break;
                default:
                    Console.WriteLine("Можно выбирать 1 или 2 или 3");
                    break;
            }



            //ConsoleLogStrategy kek2 = new ConsoleLogStrategy();

            //Logger kek = new Logger(path, "kek", kek2);

            //kek.Log();
        }
    }
}