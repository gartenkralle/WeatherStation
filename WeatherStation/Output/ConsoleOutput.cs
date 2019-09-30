using WeatherStation.View.Interfaces;

namespace WeatherStation.Output
{
    class ConsoleOutput : IOutput
    {
        public void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}
