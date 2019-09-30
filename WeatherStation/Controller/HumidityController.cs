using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;

namespace WeatherStation.Controller
{
    public class HumidityController
    {
        private readonly ITemperatureModel humidity;

        public HumidityController(ITemperatureModel humidity)
        {
            this.humidity = humidity;
        }

        public void Display(IHumidityView report)
        {
            report.Display(humidity);
        }
    }
}
