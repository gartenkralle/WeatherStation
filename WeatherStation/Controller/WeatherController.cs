using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;

namespace WeatherStation.Controller
{
    public class WeatherController
    {
        private readonly ITemperatureModel humidity;
        private readonly ITemperatureModel temperature;
        private readonly IPressureModel pressure;

        public WeatherController(ITemperatureModel humidity, ITemperatureModel temperature, IPressureModel pressure)
        {
            this.humidity = humidity;
            this.temperature = temperature;
            this.pressure = pressure;
        }

        public void Display(IMainView report)
        {
            report.Display(pressure, temperature, humidity);
        }
    }
}
