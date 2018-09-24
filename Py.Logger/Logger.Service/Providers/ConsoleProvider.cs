using System;
using Logger.Service.Entities;
using Logger.Service.Enums;

namespace Logger.Service.Providers
{
    public class ConsoleProvider: ILogProvider
    {

        public void WriteMessage(LogEntity messageEntity)
        {
            switch (messageEntity.Type)
            {
                case LogType.Message: Console.ForegroundColor = ConsoleColor.White; break;
                case LogType.Warning: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case LogType.Error: Console.ForegroundColor = ConsoleColor.Red; break;
            }
            Console.WriteLine(messageEntity.FormattedMessage);
        }
    }
}
