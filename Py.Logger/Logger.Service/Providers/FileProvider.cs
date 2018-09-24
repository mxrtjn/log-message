using System;
using System.Configuration;
using System.IO;
using Logger.Service.Entities;

namespace Logger.Service.Providers
{
    public class FileProvider: ILogProvider
    {
        readonly string FilePath;

        public FileProvider()
        {
            FilePath = ConfigurationManager.AppSettings["LogFilePath"];
            if (FilePath == null)
                FilePath = string.Format("log-{0}.log",DateTime.UtcNow.ToString(("MM-dd-yyyy")));
        }

        public void WriteMessage(LogEntity messageEntity)
        {
            using (StreamWriter fileWriter = File.AppendText(FilePath))
            {
                fileWriter.WriteLine(messageEntity.FormattedMessage);
            }
        }
    }
}
