using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View.Console
{
    public class PressureView : IPressureView
    {
        private readonly IOutput output;

        public PressureView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressureModel pressure)
        {
            output.Write("Pressure: ");
            output.WriteLine(pressure.Data.ToString());

            pressure.Changed += Pressure_Changed;
        }

        private void Pressure_Changed(ValueType data)
        {
            output.Write("Pressure: ");
            output.WriteLine(data.ToString());
        }
    }
}
