using WeatherStation.View.Interfaces;

namespace WeatherStation.Output
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}
