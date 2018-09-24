using System;
using Logger.Service.Enums;

namespace Logger.Service
{
    public interface ILogHandler
    {

        void Initialize(ProviderType type);
        void LogMessage(string message);
        void LogWarning(string warningMessage);
        void LogError(string errorMessage);

    }
}
