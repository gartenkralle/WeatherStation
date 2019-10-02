using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View.Gui
{
    public class HumidityView : IHumidityView
    {
        private readonly IOutput output;

        public HumidityView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IHumidityModel humidity)
        {
            output.Write(humidity.Data.ToString());

            humidity.Changed += Humidity_Changed;
        }

        private void Humidity_Changed(ValueType data)
        {
            output.Write(data.ToString());
        }
    }
}
