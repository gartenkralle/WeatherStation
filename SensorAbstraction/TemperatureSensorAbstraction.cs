using Sensor;
using System;
using WeatherStation.Model.Interfaces.SensorAbstraction;

namespace WeatherStation.SensorAbstraction
{
    public class TemperatureSensorAbstraction : ITemperatureSensorAbstraction
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

        public TemperatureSensorAbstraction(int pollingIntervall)
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => TemperatureSensor.Data, TemperatureChanged, pollingIntervall);
        }

        private void TemperatureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
