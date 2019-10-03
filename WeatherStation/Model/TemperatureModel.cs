using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.SensorAbstraction;

namespace WeatherStation.Model
{
    public class TemperatureModel : ITemperatureModel
    {
        private readonly ITemperatureSensorAbstraction temperature;

        public TemperatureModel(ITemperatureSensorAbstraction temperature)
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
