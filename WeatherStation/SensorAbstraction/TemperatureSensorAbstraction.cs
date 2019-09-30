using System;
using WeatherStation.Sensor;
using WeatherStation.SensorAbstraction.Interfaces.SensorAbstraction;

namespace WeatherStation.SensorAbstraction
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
