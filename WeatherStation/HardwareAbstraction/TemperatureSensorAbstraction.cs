using System;
using WeatherStation.Hardware;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    class TemperatureSensorAbstraction : ITemperatureSensorAbstraction
    {
        private readonly Helper.Hardware hardware;
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
            hardware = new Helper.Hardware();
            hardware.Poll(() => TemperatureSensor.Data, TemperatureChanged);
        }

        private void TemperatureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
