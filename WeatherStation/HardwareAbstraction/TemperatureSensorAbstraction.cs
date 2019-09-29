using System;
using WeatherStation;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    class TemperatureSensorAbstraction : ITemperatureSensorAbstraction
    {
        private readonly Hardware hardware;
        public event Action<ValueType> Changed;

        public double Data
        {
            get
            {
                return TemperatureSensor.Data;
            }
        }

        public TemperatureSensorAbstraction()
        {
            hardware = new Hardware();
            hardware.Poll(() => TemperatureSensor.Data, TemperatureChanged);
        }

        private void TemperatureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
