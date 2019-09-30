using WeatherStation.Controller.Interfaces.Model;

namespace WeatherStation.Controller.Interfaces.View
{
    public interface IMainView
    {
        void Display(IPressureModel pressure, ITemperatureModel temperature, ITemperatureModel humidity);
    }
}
