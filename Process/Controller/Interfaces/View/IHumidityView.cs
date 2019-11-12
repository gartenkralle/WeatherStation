using WeatherStation.Controller.Interfaces.Model;

namespace WeatherStation.Controller.Interfaces.View
{
    public interface IHumidityView
    {
        void Display(IHumidityModel humidity);
    }
}
