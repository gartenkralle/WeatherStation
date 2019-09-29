using System;
using WeatherStation.BusinessLogic.Interfaces;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class TemperatureView : IReport
    {
        private readonly IOutput output;

        public TemperatureView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressure pressure, ITemperature temperature, IHumidity humidity)
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
