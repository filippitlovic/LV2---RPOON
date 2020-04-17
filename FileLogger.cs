using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2___RPOON_zadaci
{
    //4. zadatak
    /*
    internal class FileLogger : ILogger
    {
        private String filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer =
                new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
        
    }
    */


    //5. ZADATAK
    /*
    internal class FileLogger : ILogger
    {
        private String filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(ILoggable data)
        {
            using (System.IO.StreamWriter writer =
                new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }

    }*/

    
}
