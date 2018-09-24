using System;
using Logger.Service.Entities;

namespace Logger.Service.Providers
{
    public interface ILogProvider
    {
        void WriteMessage(LogEntity messageEntity);
    }
}
