using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class WeatherView : IWeatherView
    {
        private readonly IOutput output;

        public WeatherView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressureModel pressure, ITemperatureModel temperature, ITemperatureModel humidity)
        {
            output.WriteLine("Initial Humunidity: " + humidity.Data);
            output.WriteLine("Initial Temperature: " + temperature.Data);
            output.WriteLine("Initial Pressure: " + pressure.Data);

            humidity.Changed += Humidity_Changed;
            temperature.Changed += Temperature_Changed;
            pressure.Changed += Pressure_Changed;
        }

        private void Humidity_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Humunidity: " + data);
        }

        private void Temperature_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Temperature: " + data);
        }

        private void Pressure_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Pressure: " + data);
        }
    }
}
