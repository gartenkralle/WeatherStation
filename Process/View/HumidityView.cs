using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.Shared.Model;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    public class HumidityView : IHumidityView
    {
        private readonly IConcreteOutput output;

        public HumidityView(IConcreteOutput output)
        {
            this.output = output;
        }

        public void Display(IHumidityModel humidity)
        {
            output.SetText(humidity.Data.ToString());

            humidity.Changed += Humidity_Changed;
        }

        private void Humidity_Changed(object sender, SensorDataEventArgs sensorData)
        {
            output.SetText(sensorData.Value.ToString());
        }
    }
}
