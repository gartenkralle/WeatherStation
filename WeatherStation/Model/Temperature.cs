using System;
using WeatherStation.BusinessLogic.Interfaces;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.Model
{
    public class Temperature : ITemperature
    {
        private readonly ITemperatureSensorAbstraction temperature;

        public Temperature(ITemperatureSensorAbstraction temperature)
        {
            this.temperature = temperature;
            temperature.Changed += Temperature_Changed;
        }

        public double Data => temperature.Data;

        public event Action<ValueType> Changed;

        private void Temperature_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
