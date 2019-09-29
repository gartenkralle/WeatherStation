using System;
using WeatherStation.Hardware;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    class PressureSensorAbstraction : IPressureSensorAbstraction
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
