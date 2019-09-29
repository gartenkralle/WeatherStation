namespace WeatherStation.BusinessLogic
{
    public class WeatherController
    {
        private readonly IHumidity humidity;
        private readonly ITemperature temperature;
        private readonly IPressure pressure;

        public WeatherController(IHumidity humidity, ITemperature temperature, IPressure pressure)
        {
            this.humidity = humidity;
            this.temperature = temperature;
            this.pressure = pressure;
        }

        public void Display(IReport report)
        {
            report.Display(pressure, temperature, humidity);
        }
    }
}
