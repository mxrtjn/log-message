using System;
using Logger.Service;
using Logger.Service.Enums;

namespace Py.Logger.console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ILogHandler logHandler = new LogHandler();
            logHandler.Initialize(ProviderType.File );
            logHandler.LogMessage("Message text");
            logHandler.LogWarning("Warning text");
            logHandler.LogError("Error text");
            Console.ReadKey();
        }
    }
}
