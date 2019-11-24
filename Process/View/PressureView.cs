using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    public class PressureView : IPressureView
    {
        private readonly IConcreteOutput output;

        public PressureView(IConcreteOutput output)
        {
            this.output = output;
        }

        public void Display(IPressureModel pressure)
        {
            output.SetText(pressure.Data.ToString());

            pressure.Changed += Pressure_Changed;
        }

        private void Pressure_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            output.SetText(sensorData.Value.ToString());
        }
    }
}
