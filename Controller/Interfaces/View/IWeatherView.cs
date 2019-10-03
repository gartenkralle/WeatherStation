using WeatherStation.Controller.Interfaces.Model;

namespace WeatherStation.Controller.Interfaces.View
{
    public interface IWeatherView
    {
        void Display(IPressureModel pressure, ITemperatureModel temperature, IHumidityModel humidity);
    }
}
