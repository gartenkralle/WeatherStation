using System;
using WeatherStation.BusinessLogic;

namespace WeatherStation.View
{
    class HumidityView : IReport
    {
        private readonly IOutput output;

        public HumidityView(IOutput output)
        {
            this.output = output;
        }

        public void Display(IPressure pressure, ITemperature temperature, IHumidity humidity)
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
