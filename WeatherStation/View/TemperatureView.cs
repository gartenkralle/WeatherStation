using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    public class TemperatureView : ITemperatureView
    {
        private readonly IOutput output;

        public TemperatureView(IOutput output)
        {
            this.output = output;
        }

        public void Display(ITemperatureModel temperature)
        {
            output.WriteLine("Initial Temperature: " + temperature.Data);

            temperature.Changed += Temperature_Changed;
        }

        private void Temperature_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Temperature: " + data);
        }
    }
}
