namespace WeatherStation.BusinessLogic.Interfaces
{
    public interface IView
    {
        void Display(IPressure pressure, ITemperature temperature, IHumidity humidity);
    }
}
