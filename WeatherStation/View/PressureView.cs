using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class PressureView : IPressureView
    {
        private readonly IOutput output;

        public PressureView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressureModel pressure)
        {
            output.WriteLine("Initial Pressure: " + pressure.Data);

            pressure.Changed += Pressure_Changed;
        }

        private void Pressure_Changed(ValueType data)
        {
            output.WriteLine("Spontaeous Pressure: " + data);
        }
    }
}
