using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class HumidityView : IHumidityView
    {
        private readonly IOutput output;

        public HumidityView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IHumidityModel humidity)
        {
            output.WriteLine("Initial Humunidity: " + humidity.Data);

            humidity.Changed += Humidity_Changed;
        }

        private void Humidity_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Humunidity: " + data);
        }
    }
}
