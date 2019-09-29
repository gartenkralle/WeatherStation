namespace WeatherStation.BusinessLogic.Interfaces
{
    public interface IReport
    {
        void Display(IPressure pressure, ITemperature temperature, IHumidity humidity);
    }
}
