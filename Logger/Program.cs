using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFileLogger<int> localFileLogger1 = new LocalFileLogger<int>($"{Environment.CurrentDirectory}\text.txt");
            LocalFileLogger<string> localFileLogger2 = new LocalFileLogger<string>($"{Environment.CurrentDirectory}\text.txt");
            localFileLogger1.LogInfo("класс");
            localFileLogger1.LogWarning("кайф");
            localFileLogger2.LogInfo("класс");
            localFileLogger2.LogWarning("кайф");
        }
    }
}
