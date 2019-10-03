using Sensor;
using System;
using WeatherStation.Model.Interfaces.SensorAbstraction;

namespace WeatherStation.SensorAbstraction
{
    public class PressureSensorAbstraction : IPressureSensorAbstraction
    {
        private readonly Helper.Hardware hardware;
        public event Action<ValueType> Changed;

        public double Data
        {
            get
            {
                return PressureSensor.Data;
            }
        }

        public PressureSensorAbstraction()
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => PressureSensor.Data, PressureChanged);
        }

        private void PressureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
