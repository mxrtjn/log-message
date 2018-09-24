using System;
using System.Collections.Generic;
using Logger.Service.Enums;
using Logger.Service.Entities;
using Logger.Service.Providers;

namespace Logger.Service
{
    public class LogHandler : ILogHandler
    {
        private List<ILogProvider> providerList;

        public void Initialize(ProviderType type)
        {
            providerList = new List<ILogProvider>();
            switch (type)
            {
                case ProviderType.Console: providerList.Add(new ConsoleProvider()); break;
                case ProviderType.File: providerList.Add(new FileProvider()); break;
                case ProviderType.Database: providerList.Add(new DatabaseProvider()); break;
                case ProviderType.All: 
                    providerList.Add(new ConsoleProvider());
                    providerList.Add(new FileProvider());
                    providerList.Add(new DatabaseProvider());
                    break;
            }
        }

        public void LogMessage(string message)
        {
            foreach (var provider in providerList)
            {
                provider.WriteMessage(new LogEntity(LogType.Message, message));
            }
        }

        public void LogWarning(string warningMessage)
        {
            foreach (var provider in providerList)
            {
                provider.WriteMessage(new LogEntity(LogType.Warning, warningMessage));
            }
        }

        public void LogError(string errorMessage)
        {
            foreach (var provider in providerList)
            {
                provider.WriteMessage(new LogEntity(LogType.Error, errorMessage));
            }
        }

    }
}
