using System;
using WeatherStation.BusinessLogic.Interfaces;
using WeatherStation.View.Interfaces;

namespace WeatherStation.View
{
    class PressureView : IReport
    {
        private readonly IOutput output;

        public PressureView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressure pressure, ITemperature temperature, IHumidity humidity)
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
