using WeatherStation.Controller.Interfaces.Model;

namespace WeatherStation.Controller.Interfaces.View
{
    public interface ITemperatureView
    {
        void Display(ITemperatureModel temperature);
    }
}
