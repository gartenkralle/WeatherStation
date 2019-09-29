using WeatherStation.Model;

namespace WeatherStation.BusinessLogic
{
    public interface IReport
    {
        void Display(IPressure pressure, ITemperature temperature, IHumidity humidity);
    }
}
