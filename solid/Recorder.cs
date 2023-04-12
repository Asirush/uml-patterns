using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakayaraznica
{
    internal class Recorder
    {
        private static readonly string _file = "test.txt";
        private static string NowDateTime() => DateTime.Now.ToString("MM/dd/yy H:mm:ss zzz");
        private static async void WriteRecord(string level, string message, bool async)
        {
            string logEntry = $"[{level}]\t{NowDateTime()}\t{message}";
            Console.WriteLine(logEntry);
            if (async)
            {
                using (StreamWriter sw = new StreamWriter(_file, append: true))
                {
                    await sw.WriteLineAsync(logEntry);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(_file, append: true))
                {
                    sw.WriteLine(logEntry);
                }
            }
        }
    }
}
