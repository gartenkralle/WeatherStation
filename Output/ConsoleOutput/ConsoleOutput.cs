using System;
using WeatherStation.View.Interfaces;

namespace WeatherStation.ConsoleOutput
{
    public class ConsoleOutput : IConcreteOutput
    {
        private readonly static object writeLineLock = InitializeWriteLock();
        private readonly string label;
        private readonly int lineNumber;

        private static object InitializeWriteLock()
        {
            return new object();
        }

        public ConsoleOutput(int lineNumber, string label)
        {
            this.label = label;
            this.lineNumber = lineNumber;
        }

        public void SetText(string s)
        {
            lock (writeLineLock)
            {
                Console.SetCursorPosition(0, lineNumber);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, lineNumber);
                Console.WriteLine(label + ": " + s);
            }
        }
    }
}
