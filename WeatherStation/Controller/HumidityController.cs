using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;

namespace WeatherStation.Controller
{
    public class HumidityController
    {
        private readonly IHumidityModel humidity;

        public HumidityController(IHumidityModel humidity)
        {
            this.humidity = humidity;
        }

        public void Display(IHumidityView view)
        {
            view.Display(humidity);
        }
    }
}
