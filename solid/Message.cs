using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakayaraznica
{
    internal abstract class Message
    {
        private static string _file = "test.txt";

        public static void WriteMessage(string message, bool async)
        {
            Recorder recorder = new Recorder();
            recorder.WriteRecord("message", message, async);
        }
    }
}
