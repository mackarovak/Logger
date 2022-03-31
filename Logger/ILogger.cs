using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    internal interface ILogger
    {
        void LogInfo(string message);

        void LogWarning(string message);

        void LogError(string message, Exception ex);
    }
}
