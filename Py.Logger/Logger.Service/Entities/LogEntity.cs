using System;
using Logger.Service.Enums;

namespace Logger.Service.Entities
{
    public class LogEntity
    {
        public string Message { get; private set; }

        public LogType Type { get; private set; }

        public string FormattedMessage
        {
            get
            {
                return String.Format("[{0}] - {1} - {2}", DateTime.UtcNow, Type, Message);
            }
        }


        internal LogEntity(LogType type, string message)
        {
            Message = message;
            Type = type;
        }
    }
}
