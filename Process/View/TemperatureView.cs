using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    public class TemperatureView : ITemperatureView
    {
        private readonly IConcreteOutput output;

        public TemperatureView(IConcreteOutput output)
        {
            this.output = output;
        }

        public void Display(ITemperatureModel temperature)
        {
            output.SetText(temperature.Data.ToString());

            temperature.Changed += Temperature_Changed;
        }

        private void Temperature_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            output.SetText(sensorData.Value.ToString());
        }
    }
}
