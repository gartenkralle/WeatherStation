using WeatherStation.Controller.Interfaces.Model;

namespace WeatherStation.Controller.Interfaces.View
{
    public interface IPressureView
    {
        void Display(IPressureModel pressure);
    }
}
