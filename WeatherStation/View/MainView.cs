using System;
using WeatherStation.BusinessLogic.Interfaces;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class MainView : IView
    {
        private readonly IOutput output;

        public MainView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressure pressure, ITemperature temperature, IHumidity humidity)
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
