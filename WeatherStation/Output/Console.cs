using WeatherStation.View;

namespace WeatherStation.Output
{
    class Console : IOutput
    {
        public void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}
