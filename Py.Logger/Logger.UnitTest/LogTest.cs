using System;
using Logger.Service.Entities;
using Logger.Service.Enums;
using NUnit.Framework;

namespace Logger.UnitTest
{
    public class LogTest
    {
        [Test()]
        public void TestFormattedMessage()
        {
            var message = "test message";
            var formattedMessage = string.Format("[{0}] - {1} - {2}", DateTime.UtcNow, LogType.Warning, message);
            var logMessageEntity = new LogEntity(LogType.Warning, message);
            Assert.AreEqual(formattedMessage, logMessageEntity.FormattedMessage);
        }       
    }
}
