using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    internal class LocalFileLogger<T> : ILogger
    {
        private readonly string path;
        private string GenericTypeName => typeof(T).Name;

        public LocalFileLogger(string path)
        {
            this.path = path;
        }

        public void LogInfo(string message)
        {
            Write($"[Info]: [{GenericTypeName}]: {message}");
        }

        public void LogWarning(string message)
        {
            Write($"[Warning]: [{GenericTypeName}]: {message}");
        }

        public void LogError(string message, Exception ex)
        {
            Write($"[Error]: [{GenericTypeName}]: {message}");
        }

        private void Write(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
