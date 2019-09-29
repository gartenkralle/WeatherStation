using System;
using WeatherStation;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    class PressureSensorAbstraction : IPressureSensorAbstraction
    {
        private readonly Hardware hardware;
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
            hardware = new Hardware();
            hardware.Poll(() => PressureSensor.Data, PressureChanged);
        }

        private void PressureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
