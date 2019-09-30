using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;

namespace WeatherStation.Controller
{
    public class TemperatureController
    {
        private readonly ITemperatureModel temperature;

        public TemperatureController(ITemperatureModel temperature)
        {
            this.temperature = temperature;
        }

        public void Display(ITemperatureView report)
        {
            report.Display(temperature);
        }
    }
}
