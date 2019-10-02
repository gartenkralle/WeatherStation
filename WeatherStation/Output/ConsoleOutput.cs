using System;
using WeatherStation.View.Interfaces;

namespace WeatherStation.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}

